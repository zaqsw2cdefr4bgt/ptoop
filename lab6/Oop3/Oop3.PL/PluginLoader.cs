using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Oop3.Contracts;

namespace Oop3.PL
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/Double-checked_locking
    /// https://en.wikipedia.org/wiki/Singleton_pattern
    /// </summary>
    internal class PluginLoader
    {
        private static PluginLoader _instance;
        private static readonly object InstanceLock;

        static PluginLoader()
        {
            InstanceLock = new object();
        }

        public static PluginLoader Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (InstanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new PluginLoader();
                        }
                    }
                }

                return _instance;
            }
        }

        public List<Type> LoadAllPersonTypes()
        {
            var personTypes = LoadPersonTypes() ?? new List<Type>();

            personTypes.AddRange(LoadPlugins());

            return personTypes;
        }

        private List<Type> LoadPersonTypes()
        {
            var personTypes = new List<Type>();

            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type t in a.GetTypes())
                {
                    if (t.IsSubclassOf(typeof(Person)))
                    {
                        personTypes.Add(t);
                    }
                }
            }
            return personTypes;
        }
        private List<Type> LoadPlugins()
        {
            var personTypes = new List<Type>();
            string[] assemblies = Directory.GetFiles("Plugins", "*.dll");

            foreach (String file in assemblies)
            {
                try
                {
                    if (File.Exists(file))
                    {
                        // load the assembly
                        var asm = Assembly.LoadFrom(file);

                        // get all types from the assembly that inherit ITask
                        var query = from t in asm.GetTypes()
                            where t.IsSubclassOf(typeof(Person))
                            select t;

                        // add types to list of startup tasks
                        foreach (Type type in query)
                        {
                            personTypes.Add(type);
                        }
                    }
                }
                catch
                {
                }
            }

            return personTypes;
        }
    }
}