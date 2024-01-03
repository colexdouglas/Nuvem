USE master;
CREATE TABLE Pharmacy (
    PharmacyId INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Address NVARCHAR(100) NOT NULL,
    City NVARCHAR(100) NOT NULL,
    State NVARCHAR(100) NOT NULL,
    Zip INT NOT NULL,
    PrescriptionsFilled INT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedDate DATETIME
);
INSERT INTO Pharmacy (PharmacyId, Name, Address, City, State, Zip, PrescriptionsFilled)
VALUES (1645, 'Kroger Pharmacy', '12600 N Beach St', 'Fort Worth', 'TX', 76244, 6445),
       (1646, 'Walgreens Pharmacy', '12450 Timberland Blvd', 'Fort Worth', 'TX', 76244, 4845);
       {
  "pharmacyId": 1645,
  "name": "Kroger Pharmacy",
  "address": "12600 N Beach St",
  "city": "Fort Worth",
  "state": "TX",
  "zip": 76244,
  "prescriptionsFilled": 7777,
  "createdDate": "2024-01-01T22:30:07.706Z",
  "updatedDate": "2024-01-01T22:30:07.706Z"
}