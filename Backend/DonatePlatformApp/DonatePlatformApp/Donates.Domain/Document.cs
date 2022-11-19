using Donates.Authentication.Enums;

namespace Donates.Authentication.Entities;

public class Document
{
    public int Id { get; set; }
    public DocumentType DocumentType { get; set; }
    public string Series { get; set; }
    public long Number { get; set; }
}