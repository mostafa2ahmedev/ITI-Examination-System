# ITI Examination System

The **ITI Examination System** is designed to provide a flexible and interactive way to manage, display, and evaluate exams. This system allows users to conduct both practical and final exams, with support for multiple question types like multiple choice, true/false, and multiple answer questions.

## Features

- **Question Types**: 
  - **Multiple Choice Questions (COQuestion)**: A single correct answer from a list of options.
  - **True/False Questions (TFQuestion)**: A simple true/false question.
  - **Multiple Answer Questions (CAQuestion)**: A question requiring multiple correct answers.

- **Exams**: 
  - **Practice Exam (PracticeExam)**: Simulates a practice environment, with the ability to show questions and collect answers.
  - **Final Exam (FinalExam)**: A formal exam type that can be timed and graded based on the user's answers.

- **Marking System**: Each question has a specific mark assigned, and the system keeps track of the user's score.

- **Answer Validation**: The system validates answers against a dictionary of correct answers and provides feedback.

## Structure

The system is organized into several core components:

### 1. **Questions**
   - **Question Class**: Base class with properties such as `Header`, `Body`, `Marks`, and a list of possible answers.
   - **COQuestion**: A derived class for multiple-choice questions (one correct answer).
   - **TFQuestion**: A derived class for true/false questions.
   - **CAQuestion**: A derived class for questions with multiple correct answers.

### 2. **Answers**
   - **Answer Class**: Represents a single answer choice for any question.
   - **AList**: A custom list class to store answers.

### 3. **Exams**
   - **Exam Class (abstract)**: The base class for different types of exams, containing properties like `Time`, `NOQuestions`, and `Subject`.
   - **PracticeExam**: Derived class that simulates a practice exam.
   - **FinalExam**: Derived class for the actual final exam, with time limits and a scoring system.

### 4. **Subject**
   - The `Subject` class represents the subject of the exam (e.g., "Programming").

### 5. **QList**
   - A custom list to manage questions, log them to a file, and add them to the exam.

## Functionality

1. **Adding Questions**: 
   - The system allows you to create and add different types of questions to an exam.

2. **Displaying the Exam**: 
   - Based on the type of exam selected (Final or Practical), the system displays all the questions, allows the user to input answers, and calculates the score.

3. **Logging Questions**: 
   - Each time a question is added, its header, body, and marks are logged into a file for record-keeping.

4. **Scoring**: 
   - The system checks the user’s responses against the correct answers, accumulates the score, and displays it at the end of the exam.

## How It Works

- The program begins by prompting the user to choose between a **Final Exam** or a **Practical Exam**.
- The user then sees each question along with the possible answers.
- For each question, the user selects an answer or answers (depending on the question type).
- After answering all questions, the system calculates the score based on the user's inputs and displays the result.

## Example Workflow

1. **Select Exam Type**: The user is prompted to choose between "Final" or "Practical".
2. **Display Questions**: The exam type determines which set of questions is shown.
3. **Answer Questions**: The user enters their answers to each question.
4. **Score Calculation**: After answering, the system calculates the total score based on the correct answers.
5. **Correct Answers**: The system then displays the correct answers for each question.

