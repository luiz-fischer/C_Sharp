// using System;
// using System.Collections.Generic;
// using NUnit.Framework;

// namespace ModelTests
// {
// 	public class GetClientesTestCase
// 	{
// #region Test methods
// 		[Test]
// 		[TestCaseSource(nameof(ExpectedReturnValueTests))]
// 		public void GetClientesTest(ExpectedValueTestData<List<Model.Cliente>> data)
// 		{
// 			var actual = Model.Cliente.GetClientes();
// 			Assert.AreEqual(data.ExpectedValue, actual);
// 		}

// 		[Test]
// 		[TestCaseSource(nameof(TestsThrowingException))]
// 		public void GetClientesTestThrowingException(TestThrowingExceptionData data)
// 		{
// 			Assert.Throws(data.ExpectedException, () => Model.Cliente.GetClientes());
// 		}
// #endregion

// #region Data
// 		private static IEnumerable<TestCaseData> ExpectedReturnValueTests()
// 		{
// 			yield return new TestCaseData(
// 				new ExpectedValueTestData<List<Model.Cliente>>
// 				{
// 					ExpectedValue = /* TODO: Replace 'default' by your expected value */ default,
// 				}).SetName(@"set your test name here - set your test description here");
// 		}

// 		private static IEnumerable<TestCaseData> TestsThrowingException()
// 		{
// 			yield return new TestCaseData(
// 				new TestThrowingExceptionData
// 				{
// 					ExpectedException = /* TODO: Replace 'Exception' by your expected exception */ typeof(Exception),
// 				}).SetName(@"set your test name here - set your test description here");
// 		}
// #endregion

// #region Types
// 		public struct ExpectedValueTestData<TExpected>
// 		{
// 			public TExpected ExpectedValue;
// 		}

// 		public struct TestThrowingExceptionData
// 		{
// 			public Type ExpectedException;
// 		}
// #endregion
// 	}
// }
