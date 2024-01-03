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
       (1646, 'Walgreens Pharmacy', '12450 Timberland Blvd', 'Fort Worth', 'TX', 76244, 4845), 
       (1647, 'ALEXA PHARMACY', '967 Keller Pkwy ste c', 'Keller', 'TX', 76248, 555),
       (1648, 'Sams Club Pharmacy', '201 Golden Triangle Boulevard', 'Keller', 'TX', 76248, 1213),
       (1649, 'Bear Creek Pharmacy LLC', '101 Bear Creek Pkwy Ste B', 'Keller', 'TX', 76248, 112);
