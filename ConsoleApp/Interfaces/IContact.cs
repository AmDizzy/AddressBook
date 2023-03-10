namespace ConsoleApp.Interfaces;

internal interface IContact
{
    Guid Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    string PhoneNumber { get; set; }
    string StreetAdress { get; set; }
    string PostalCode { get; set; }
    string City { get; set; }
    string Address => $"{StreetAdress}, {PostalCode} {City}";
    string DisplayName => $"{FirstName} {LastName}";
}