public class DocumentVerification
{
    public int Id { get; set; }
    public string DocumentType { get; set; }
    public byte[] ScannedDocument { get; set; }
    // Additional fields for OCR results, status, etc.
}
