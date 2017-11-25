
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
    201
  , 'Hardware, BIOS'
  , 'TrueFalse'
  , 0
  , 0
  , 0
  ,'First, the BIOS initializes the system'
  , 1
  , 'True, False'
  , 'The answer is true, the first thing a BIOS does is initialize your system,\n -Making sure you have all hardware components needed to continue loading an Operating System (OS).\n -Checks the cpu is installed and operating properly.\n -Checks the memory is installed and operating properly.'
)

values
(
    202
  , 'Hardware, Stages'
  , 'TrueFalse'
  , 0
  , 0
  , 0
  ,'The "computing process" describes the 3 stages computers work through. Input, Processing, and Output.'
  , 1
  , 'True, False'
  , 'The 3 stages in the computing process are: input, processing, and output. \/n In stage 1, input, you are issuing a command to the computer. \/n In stage 2, processing, it\'s usually the computers CPU thats working to complete the issued task. \/n In stage 3, output, on completion of the processing stage, the computer may play a sound or change the information displayed on screen. \/n Additionally modern computers will typically have "Data Storage" and "Network Connection" as additional stages.'
)
