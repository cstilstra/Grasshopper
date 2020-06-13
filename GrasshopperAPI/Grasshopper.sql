CREATE TABLE `grasshoppers` (
  `Id` int PRIMARY KEY AUTO_INCREMENT,
  `Name` varchar(255) UNIQUE NOT NULL
);

CREATE TABLE `senseis` (
  `Id` int PRIMARY KEY AUTO_INCREMENT,
  `Name` varchar(255) UNIQUE NOT NULL
);

CREATE TABLE `lessons` (
  `GrasshopperId` int,
  `SenseiId` int,
  `MeetingTime` timestamp NOT NULL,
  `Duration` int NOT NULL,
  PRIMARY KEY (`GrasshopperId`, `SenseiId`, `MeetingTime`)
);

ALTER TABLE `lessons` ADD FOREIGN KEY (`GrasshopperId`) REFERENCES `grasshoppers` (`Id`);

ALTER TABLE `lessons` ADD FOREIGN KEY (`SenseiId`) REFERENCES `senseis` (`Id`);

