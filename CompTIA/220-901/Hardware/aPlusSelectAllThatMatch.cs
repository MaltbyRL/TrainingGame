struct selectAllThatApply {
  struct Question1 {
    public string[] Tags = ["Hardware"]; // Tags the question to a specific area of study.
    public string[] Question = ["The typical PC runs an operating system and is used for various tasks.\n What are some general purpose computing devices?"]; // Actual question text.
    public string[] Choices = ["Apple Mac", "Apple IPAD", "Smartphone", "Portable computer", "Encyclopedia", "AM/FM Radio" , "Electric toothbrush", "Camcorder"];    // Array of answers from which user can choose.
    public int[] Answer = [1, 2, 3, 4];          // Index of correct answer within Choices.
    public string notes = ""; // Notes on subject matter.
  }
  struct Question2 {
    public string[] Tags = ["Hardware"]; // Tags the question to a specific area of study.
    public string[] Question = ["Select the 3 Major components of a modern computer"]; // Actual question text.
    public string[] Choices = ["Hardware", "Operating System (OS)", "Applications", "Motherboard (MOBO)", "Power Supply Unit (PSU)", "Basic Input Output System (BIOS)", "Windows", "Microsoft Disk Operating System (MSOS)"];    // Array of answers from which user can choose.
    public int[] Answer = [1, 2, 3];          // Index of correct answer within Choices.
    public string notes = "The correct answer is Hardware, Operating System, Applications.\n Hardware the stuff you can see and touch.\n Operating System, to control the hardware and give you control of the system.\n Applications, allow the computer or device to perform specialized tasks."; // Notes on subject matter.
  }
  struct Question3 {
    public string[] Tags = ['Hardware', 'Stages']; // Tags the question to a specific area of study.
    public string[] Question = ["Select the 3 stages in the 'computing process'"]; // Actual question text.
    public string[] Choices = ["Input", "Processing", "Output", "Computational", "Binary Conversion", "Debugging", "Download", "Upload"];    // Array of answers from which user can choose.
    public int[] Answer = [1, 2, 3];          // Index of correct answer within Choices.
    public string notes = "The 3 stages in the computing process are: input, processing, and output.\n In stage 1, input, you are issuing a command to the computer.\n In stage 2, processing, it's usually the computers CPU thats working to complete the issued task.\n In stage 3, output, on completion of the processing stage, the computer may play a sound or change the information displayed on screen.\n Additionally modern computers will typically have 'Data Storage' and 'Network Connection' as additional stages."; // Notes on subject matter.
  }
  struct Question4 {
    public string[] Tags = []; // Tags the question to a specific area of study.
    public string[] Question = [""]; // Actual question text.
    public string[] Choices = [""];    // Array of answers from which user can choose.
    public int[] Answer = [];          // Index of correct answer within Choices.
    public string notes = ""; // Notes on subject matter.
  }
  struct Question5 {
    public string[] Tags = []; // Tags the question to a specific area of study.
    public string[] Question = [""]; // Actual question text.
    public string[] Choices = [""];    // Array of answers from which user can choose.
    public int[] Answer = [];          // Index of correct answer within Choices.
    public string notes = ""; // Notes on subject matter.
  }

}
