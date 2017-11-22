
struct multipleChoice {
  struct Question1{
    public string[] Tags = ["BIOS", "220-901", "Hardware"]; // Tags the question to a specific area of study.
    public string[] Question = ["What does the acronym BIOS stand for?", "BIOS Stands for?", "BIOS is an acronym for what?"]; // Actual question text.
    public string[] Choices = ["Bianary Input Output Service", "Bianary Operating System","Basic Input Output System"];    // Array of answers from which user can choose.
    public int Answer 3;          // Index of correct answer within Choices.
    public string notes = "'For IBM PC compatible computers,
    BIOS (an acronym for Basic Input/Output
    System and also known as the System BIOS, ROM BIOS or PC BIOS)
    is non-volatile firmware used to perform hardware initialization
    during the booting process (power-on startup),
    and to provide runtime services for operating
    systems and programs' -Wikipedia"; // Notes on subject matter.
  };
  struct Question2{
      public string[] Tags = ["BIOS", "220-901", "Hardware"]; // Tags the question to a specific area of study.
    public string[] Question = ["What is needed to run the BIOS?", "Is an Operating System or storage needed to run the BIOS?", "What does the BIOS need?"]; // Actual question text.
    public string[] Choices = [ "You need both storage and the OS to run the BIOS","The BIOS will still run with no storage or OS.","You need only storage to run the BIOS", "An OS is needed to run the BIOS"];    // Array of answers from which user can choose.
    public int Answer 2;          // Index of correct answer within Choices.
    public string notes = "The BIOS is a Part of the motherboard, no storage or operating systems are needed.
    'Originally, BIOS firmware was stored in a ROM chip on the PC motherboard.
    In modern computer systems, the BIOS contents are stored on flash memory so it can be
    rewritten without removing the chip from the motherboard. This allows easy, end-user
    updates to the BIOS firmware so new features can be added or bugs can be fixed,
    but it also creates a possibility for the computer to become infected with BIOS rootkits.
    Furthermore, a BIOS upgrade that fails can brick the motherboard permanently,
    unless the system includes some form of backup for this case. -Wikipedia'"; // Notes on subject matter.
  };
  struct Question{
      public string[] Tags = ["POST", "BIOS", "220-901", "Hardware"]; // Tags the question to a specific area of study.
      public string[] Question = ["POST stands for?", "The acronym POST means?"]; // Actual question text.
      public string[] Choices = ["Power Only Serial Transmitter", "Power Start", "Power On Self Test", ];    // Array of answers from which user can choose.
      public int Answer;          // Index of correct answer within Choices.
      public string notes = ""; // Notes on subject matter.
  };
  struct Question{
      public string[] Tags = []; // Tags the question to a specific area of study.
      public string[] Question = [""]; // Actual question text.
      public string[] Choices = [];    // Array of answers from which user can choose.
      public int Answer;          // Index of correct answer within Choices.
      public string notes = ""; // Notes on subject matter.
  };
  struct Question{
      public string[] Tags = []; // Tags the question to a specific area of study.
      public string[] Question = [""]; // Actual question text.
      public string[] Choices = [];    // Array of answers from which user can choose.
      public int Answer;          // Index of correct answer within Choices.
      public string notes = ""; // Notes on subject matter.
  };
  struct Question{
      public string[] Tags = []; // Tags the question to a specific area of study.
      public string[] Question = [""]; // Actual question text.
      public string[] Choices = [];    // Array of answers from which user can choose.
      public int Answer;          // Index of correct answer within Choices.
      public string notes = ""; // Notes on subject matter.
  };
  struct Question{
      public string[] Tags = []; // Tags the question to a specific area of study.
      public string[] Question = [""]; // Actual question text.
      public string[] Choices = [];    // Array of answers from which user can choose.
      public int Answer;          // Index of correct answer within Choices.
      public string notes = ""; // Notes on subject matter.
  };
  struct Question{
      public string[] Tags = []; // Tags the question to a specific area of study.
      public string[] Question = [""]; // Actual question text.
      public string[] Choices = [];    // Array of answers from which user can choose.
      public int Answer;          // Index of correct answer within Choices.
      public string notes = ""; // Notes on subject matter.
  };
}
