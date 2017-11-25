struct ArrangeTheSet {
  struct Question1 {
    public string[] Tags = ['"Hardware", "Stages"']; // Tags the question to a specific area of study.
    public string[] Question = ['The whole computing process has many steps, and parts that interact.\n Arrange the nine most common steps in computing in an order that will accomplish a task.']; // Actual question text.
    public string[] Choices = ['"User powers up the device", "Processing parts initialise", "User provides input", "Processing Unit processes the input", "Processing Unit sends the output information to the users output device", "Output device displays the information", "User loops through the previous 4 steps until the desired result is met", "Work is saved", "User powers down the device"'];    // Array of answers from which user can choose.
    public string notes = 'Understanding the steps of traditional computing will greatly help you in future troubleshooting senerios.'; // Notes on subject matter.
  }
}

  insert into aPlusTerminologyDB
    (
      questionID
    , questionTags
    , questionType
    , questionAttempts
    , questionCorrect
    , questionIncorrect
    , questionText
    , questionAnswer
    , questionChoices
    , questionNotes
  )

  values
  (
      101
    , '"Hardware", "Stages"'
    , 'ArrangeTheSet'
    , 0
    , 0
    , 0
    ,'The whole computing process has many steps, and parts that interact.\n Arrange the nine most common steps in computing in an order that will accomplish a task.'
    , 3
    , '"User powers up the device", "Processing parts initialise", "User provides input", "Processing Unit processes the input", "Processing Unit sends the output information to the users output device", "Output device displays the information", "User loops through the previous 4 steps until the desired result is met", "Work is saved", "User powers down the device"'
    , 'Understanding the steps of traditional computing will greatly help you in future troubleshooting senerios.'
)
