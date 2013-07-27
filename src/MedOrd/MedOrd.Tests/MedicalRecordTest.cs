using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MedOrd.DomainModel;
using MedOrd.DomainModel.Exceptions;

namespace MedOrd.Tests {
	/// <summary>
	/// Summary description for MedicalExaminationTest
	/// </summary>
	[TestClass]
	public class MedicalRecordTest {
		public MedicalRecordTest() {
			//
			// TODO: Add constructor logic here
			//
		}

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext {
			get {
				return testContextInstance;
			}
			set {
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		[TestMethod]
		public void AddTherapiesTestMethod() {
			Employee employee = new Employee("test", "test", new Person("test", "test", "1234567890123"));
			employee.EmployeeRoles.Add(MedOrd.DomainModel.Enumerations.EmployeeRole.Doctor);
			MedicalExamination medExam = new MedicalExamination(employee);

			int firstCount = medExam.Therapies.Count;

			medExam.AddTherapy(new Therapy("test", "test"));
			medExam.AddTherapy(new Therapy("test2", "test2"));
			medExam.AddTherapy(new Therapy("test3", "test3"));

			Assert.AreEqual(firstCount + 3, medExam.Therapies.Count);
		}

		[TestMethod]
		[ExpectedException(typeof(NotDoctorException))]
		public void DoctorPrivilegiesOnMedicalRecordTestMethod() {
			Employee employee = new Employee("test", "test", new Person("test", "test", "1234567890123"));
			employee.EmployeeRoles.Add(MedOrd.DomainModel.Enumerations.EmployeeRole.Nurse);
			MedicalExamination medExam = new MedicalExamination(employee);
		}
	}
}
