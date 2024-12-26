using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign
{
    public class Singleton
    {
        //private instance variable
        private static Singleton instance; 

        //Private constructor
        private Singleton()
        {
            
        }

        //static method
        public static Singleton GetInstance()
        {
            if(instance == null)
            {
                //lazy initialization without using lock
                instance = new Singleton();

                //thread safe
                lock (Singleton.instance)
                {
                    if(instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;

        }



    }
}
