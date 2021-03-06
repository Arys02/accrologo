// <copyright file="AngleTest.cs">Copyright ©  2018</copyright>
using System;
using Accrologo.src;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Accrologo.src.Tests
{
    /// <summary>Cette classe contient des tests unitaires paramétrables pour Angle</summary>
    [PexClass(typeof(Angle))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AngleTest
    {
    }
}
