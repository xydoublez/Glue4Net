using System;    
public class TestModule : Glue4Net.IAppModule
    {

        public string Name
        {
            get {return "TEST"; }
        }

        public Glue4Net.IEventLog Log
        {
            get;
            set;
        }

        public void Load()
        {
            Log.Info("Test Module Load !");
           
        }

        public void UnLoad()
        {
            Log.Info("Test Module UnLoad!");
        }
    }