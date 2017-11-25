
  insert into aPlusTerminologyDB(
    questionID
    , questionTags
    , questionType
    , questionAttempts
    , questionCorrect
    , questionIncorrect
    , questionPart1
    , correctAnswer
    , questionGuess1
    , questionNotes
  )
  values
  (
    1
    , 'BIOS'
    , 'multipleChoice'
    , 0
    , 0
    , 0
    ,'What does the acronym BIOS stand for?'
    , 3
    , 'Bianary Input Output Service \n Bianary Operating System \n Basic Input Output System'
    ,'For IBM PC compatible computers\, BIOS (an acronym for Basic Input/Output System and also known as the System BIOS\, ROM BIOS or PC BIOS) is non-volatile firmware used to perform hardware initialization during the booting process (power-on startup)\, and to provide runtime services for operating systems and programs -Wikipedia')
)

  insert into aPlusTerminologyDB(
    questionID,
    questionTags,
    questionType,
    questionAttempts,
    questionCorrect ,
    questionIncorrect,
    questionPart1,
    correctAnswer,
    questionGuess1 ,
    questionNotes)
  values
  (
    2
    , 'BIOS'
    , 'multipleChoice'
    , 0
    , 0
    , 0
    ,'What is needed to run the BIOS?'
    , 2
    , '"You need both storage and the OS to run the BIOS","The BIOS will still run with no storage or OS.","You need only storage to run the BIOS", "An OS is needed to run the BIOS"'
    ,'The BIOS is a Part of the motherboard, no storage or operating systems are needed.
    "Originally, BIOS firmware was stored in a ROM chip on the PC motherboard.
    In modern computer systems, the BIOS contents are stored on flash memory so it can be
    rewritten without removing the chip from the motherboard. This allows easy, end-user
    updates to the BIOS firmware so new features can be added or bugs can be fixed,
    but it also creates a possibility for the computer to become infected with BIOS rootkits.
    Furthermore, a BIOS upgrade that fails can brick the motherboard permanently,
    unless the system includes some form of backup for this case. -Wikipedia"'
  )
