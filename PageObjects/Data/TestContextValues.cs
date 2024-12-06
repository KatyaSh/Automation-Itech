using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.Data
{
     public class TestContextValues   
    {       
        public static string ExecutableClassName => TestContext.CurrentContext.Test.ClassName;
    }
}
