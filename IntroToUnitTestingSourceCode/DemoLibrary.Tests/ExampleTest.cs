﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
    public class ExampleTest
    {
        [Fact]
        public void ExamplTextFile_ValidNameShouldWork()
        {
            string actual = Examples.ExampleLoadTextFile("This is a valid file name.");            
            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void ExamplTextFile_InvalidNameShouldFail()
        {

            Assert.Throws<ArgumentException>("file",()=>Examples.ExampleLoadTextFile(""));

        }


    }
}
