ITI Examination System
Overview
The ITI Examination System is a console application designed to manage and administer various types of exams, including multiple-choice, true/false, and multiple-answer questions. It allows users to select an exam (Final or Practical) and answer a series of questions, which are evaluated based on the correct answers. This system is structured using object-oriented programming concepts and follows a modular design for ease of extension and maintenance.

Key Features
Exam Types: Supports different types of exams, including:

Final Exam: Comprehensive exam with a time limit.

Practical Exam: Focused on practical questions, also with a time limit.

Question Types:

Multiple Choice (COQuestion): One correct answer.

True/False (TFQuestion): Simple true/false question format.

Multiple Answer (CAQuestion): Allows multiple correct answers.

Answer Validation: After the user selects their answers, the system checks them against the correct answers and scores the exam accordingly.

Logging: Each question added to the exam is logged to a file, which includes details such as the question header, marks, and body.

Structure and Classes
1. Program Class
The entry point of the application. It initializes the question list, prompts the user to choose an exam type (Final or Practical), and then displays the corresponding exam.

2. Question Class
A base class for all question types. It contains properties such as the question body, header, marks, and a list of possible answers.

3. COQuestion, TFQuestion, CAQuestion
Inherits from the Question class and represents different types of questions:

COQuestion: Single-choice question.

TFQuestion: True/False question.

CAQuestion: Multiple-answer question.

4. Answer Class
Represents an individual answer choice. It contains the answer text and overrides methods for equality comparison and hashing.

5. Exam Class (Abstract)
An abstract class that defines the structure of an exam. It contains properties like the number of questions, time limit, and the subject. The ShowExam method is abstract, and the subclasses (like FinalExam and PracticeExam) implement it to display the exam and grade it.

6. FinalExam and PracticeExam
Classes that inherit from Exam and provide specific implementations of the ShowExam method for displaying and grading the respective types of exams.

7. QList Class
A custom list class derived from List<Question>, which logs each question added to the list. It ensures that the exam questions are stored in an organized manner while maintaining logs for each addition.

8. AList Class
A custom list class derived from List<Answer>, specifically designed to hold answer choices for questions.

How it Works
Question Creation: A list of questions is created, where each question has multiple possible answers.

User Selection: The user chooses whether to take a Final or Practical exam.

Answering Questions: The system presents each question, and the user selects answers by entering the corresponding number.

Validation: The system checks the user's answers against the correct answers and computes a score.

Results Display: At the end of the exam, the system displays the total score along with the correct answers.
