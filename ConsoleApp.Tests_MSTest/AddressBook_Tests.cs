namespace ConsoleApp.Tests_MSTest;

using System.Collections.ObjectModel;
using ConsoleApp.Models;
using ConsoleApp.Services;

[TestClass]
public class Addressbook_Tests
{
    [TestMethod]
    public void Should_Add_Contact_To_List()
    {
        //Arrange
        MenuService menuService = new();
        Contact contact = new();

        //Act
        menuService.contacts.Add(contact);

        //Assert
        Assert.AreEqual(1, menuService.contacts.Count);
    }
}
