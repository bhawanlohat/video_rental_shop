using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject_video_rental
{
    [TestClass]
    public class UnitTest1
    {

        database_class obj_Data = new database_class();

        [TestMethod]
        public void TestMethod1()
        {

            {

                void TestConnection()
                {
                    // Arrange
                    var conn = new Connection();

                    // Act
                    var actual = conn.GetConn();

                    // Assert
                    Assert.AreEqual(@"DESKTOP-HL11OFI\SQLEXPRESS; Initial Catalog=RentingStore; Integrated Security=True", actual);
                }


                void Check_Rented_Movies()
                {
                    // Arrange
                    var data = new Database();

                    // Act
                    var actual = data.HasCopiesRented(0);

                    // Assert
                    Assert.AreEqual(false, actual);
                }

            }
        }
    }
}
