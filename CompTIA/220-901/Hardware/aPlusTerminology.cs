
CREATE TABLE aPlusTerm
(
  terminologyID STRING PRIMARY KEY UNIQUE NOT NULL
, terminologyAcronym STRING UNIQUE
, terminologyName STRING NOT NULL
, terminologyNotes STRING DEFAULT NULL
)


;

insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionBIOS'
, 'BIOS'
, 'Basic Input OutPut System'
, 'Notes: '
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionCMOS'
, 'CMOS'
, 'Complemetary Metal Oxide Semiconductor'
, 'Notes: '
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionCPU'
, 'CPU'
, 'Central Processing Unit'
, 'Usually a thin waffer like square of silicon and tiny transistors, \n by which the majority of processing tasks are completed.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionDVI'
, 'DVI'
, 'Notes: '
, 'A connector used for output to the monitor.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitioneSATA'
, 'eSATA'
, 'Notes: '
, 'Provides a variant of SATA meant for external connectivity. It uses a more robust connector, longer shielded cables, and stricter (but backward-compatible) electrical standards.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionFirewire'
, 'Firewire'
, 'Firewire'
, 'Firewire is a serial bus architecture for high-speed data transfer.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionGPU'
, 'GPU'
, 'Graphics Processing Unit'
, 'A graphics processing unit (GPU) is a specialized electronic circuit designed to rapidly manipulate and alter memory to accelerate the creation of images in a frame buffer intended for output to a display device.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionHDMI'
, 'HDMI'
, 'High-Definition Multimedia Interface'
, 'Proprietery interfaces use to output audio and video to a monitor.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionInput'
, 'Input'
, 'Input'
, 'Starting a computing action by doing something, typing text, clicking a mouse or manipulating a touchscreen.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionMiniDIN'
, 'Mini-DIN'
, 'Mini-DIN'
, 'A connector used for a keyboard or a mouse.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionMOBO'
, 'MOBO'
, 'Motherboard'
, 'is the main printed circuit board (PCB) found in general purpose microcomputers and other expandable systems.\n It holds and provides communication to many of the components needed for operating a computer.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionNIC'
, 'NIC'
, 'Network Interface Card'
, 'A NIC is a circuit board or card that is installed in a computer so that it can be connected to a network.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionPC'
, 'PC'
, 'Personal Computer'
, 'A PC is an electronic device that can perform calculations. \n Most common types use special programming languages that certian people write, \n and compile to perform specific tasks.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionPCB'
, 'PCB'
, 'Printed Circuit Board'
, 'A printed circuit board (PCB) mechanically supports and electrically connects electronic components using\n conductive tracks, pads and other features etched from copper sheets laminated onto a non-conductive substrate. Components are normally soldered onto PCBs.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionPS2'
, 'PS/2'
, 'Notes: '
, 'A connector used for a keyboard or a mouse.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionPSU'
, 'PSU'
, 'Power Supply Unit'
, 'Notes: '
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionRAM'
, 'RAM'
, 'Random Access Memory'
, 'Notes: '
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionSPDIF'
, 'S/PDIF'
, 'Sony/Philips Digital Interface Format'
, 'A type of connection used in consumer audio equipment to output audio over reasonably short distances.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionSSD'
, 'SSD'
, 'Solid State Drive'
, 'A device that uses integrated circuit assemblies as memory to store data persistently. SSDs have no moving mechanical parts.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionUEFI'
, 'UEFI'
, 'Unified Extensible Firmware Interface'
, 'IT is a specification that defines a software interfaces between an operating system and platform firmware. \n "It\'s a newer verson of the BIOS!". '
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionUI'
, 'UI'
, 'User Interface'
, 'Often appears as a collection of windows or icons that a user can interact with.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionUSB'
, 'USB'
, 'Notes: '
, 'A USB connector used for multiple Input or Output devices.'
)
;
insert into aPlusTerm
(
  terminologyID
, terminologyAcronym
, terminologyName
, terminologyNotes
)

values
(
'definitionVGA'
, 'VGA'
, 'Notes: '
, 'Notes: '
)
