namespace ConsoleApp.Tests;

using System.Collections.ObjectModel;
using ConsoleApp.Models;
using ConsoleApp.Services;

public class AddressBook_Tests
{
    private readonly MenuService menuService;
    readonly Contact contact;

    public AddressBook_Tests()
    {
        menuService = new MenuService();
        contact = new Contact();
    }

    [Fact]
    public void Should_Add_Contact_To_List()
    {
        // act
        menuService.contacts.Add(contact);
        menuService.contacts.Add(contact);

        // assert
        Assert.Equal(2, menuService.contacts.Count);
    }

    [Fact]
    public void Should_Remove_Contact_From_List()
    {
        // arrange
        menuService.contacts.Add(contact);
        menuService.contacts.Add(contact);

        // act
        menuService.contacts.Remove(contact);

        // assert
        Assert.Single(menuService.contacts);
    }
}