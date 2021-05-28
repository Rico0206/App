



# Project Goals

- The Project has to be a 3 - Tier Application
  - It should include a Model Layer
  - It should include a Business Layer
  - It should include a GUI Layer
- The Project has to include a Test Layer where several testcases will ensure the good functionality of the application
- The project should include an SQL database with at least two linked tables.
- In the project should be used Entity Framework to manage the relationship between the Model and Business layer
- The Project should be easily tracked by git commits and implement a thorough and readable documentation.
- The project should comply with the project description

# ERD

![DBMS ER diagram (UML notation)](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\DBMS ER diagram (UML notation).png)

# Wireframe

# Class Diagram



# Sprints



## Sprint 1 - Layout Day

![1](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\Sprint1\1.png)

![2](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\Sprint1\2.png)

### Sprint Review

##### What has been completed?

All UI basic layout is done and working and the following pages completed

- [x] Profile Page
- [x] Signup Page
- [x] Enrolment Page
- [x] Login Page

##### Problems and Solutions?

There were too many problems to go through individually but the two main problems were:

Problem 1 - the scroll bar not scrolling all the way to the bottom.

Solution  - turns out it was scrolling to the bottom its just there was no safety margin there so the bottom was always going to cut off, fixed by adding a 50 pixel margin at the bottom. Now it scroll 50 pixels past the last item on the page.

Problem 2 - getting a list of items to self produce based on a number

Solution - Still working on it, but the answer is list box's

##### What should come next?

Next I should continue the theme of working on the backbone of the project and working on the database getting the structure sorted out and tested.

### Sprint Retrospective

##### What went well?

I think the sprint went exceptionally well because the UI in my opinion is the hardest part to declare as "finished" because it is all opinion based, for this reason I believed it would take longer and spill into Sprint 2. Luckily I found some resources and stuck with a theme early which allowed to take some shortcuts and make my design process more efficient.

##### What went poorly?

It took longer than it needed to because there was no definition of done, so even though the requirements were met alterations were made based on false criteria. Next time I will make the wireframe so that I have something to work of as reference

##### Comments?

making something aesthetically pleasing as well as professional is difficult. WPF makes it easier though.

#### Blockers

## Sprint 2 - Data Day

![2](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\Sprint2\2.png)

![3](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\Sprint2\3.png)

![4](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\Sprint2\4.png)





### Sprint Review

##### What has been completed?

All of todays goals have been met except for the wireframe which has been purposely delayed. This includes : 

- ERD
- Database Alteration
- Database Scaffold

##### Problems and Solutions?

Only kind of problem was checking to see the database logic flowed correctly or had any errors, for this, assistance was called in order to provide a "fresh set of eyes".

##### What should come next?

Now that the UI layout and the database is ready. it is time to start with business layer of the product which will map keys to actions and allow the database to be handled with crud functionality in order to display and edit information

### Sprint Retrospective

##### What went well?

The timings made sense. although the sprint did not have too many tasks, the day has been spread out efficiently because the tasks I did have were tasks that required time and focus to get right as it is the back bone of the project.

##### What went poorly?

some of the user stories were not as accurate as I needed them to be on this particular topic, but I had thought as much when I made them

##### Comments?

Its best to take your time with databases otherwise later it will come back to haunt you.

#### Blockers

## Sprint 3 - Business Day

![6](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\Sprint3\6.png)

![7](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\Sprint3\7.png)



### Sprint Review

##### What has been completed?

Todays goals are well on the way, today the following  has been completed:

- Sign Up Page 
- Login Page
- Profile Page
- Navigation Functionality

##### Problems and Solutions?

main problem today has been my computer crashing whilst processing too many things at once which set me back at least 2 to 3 hours, which in a way is fine because I am still within my sprint objectives, and a good lesson learnt on taking PC health into consideration.

##### What should come next?

Next I should work on finishing the rest of the functionality and the business class which will make the core product barr any finishing touches complete. tomorrow will be crucial in knowing whether a third day will be needed for business files to be finished as tomorrow will be a challenging day because I have planned some technical work.

### Sprint Retrospective

##### What went well

When I initially created the sprint I believed that I had to little work to do to fill the day but it turns out the extra time I had served as extra time for unforeseen circumstances which wasn't planned but moving forward will start to plan for. 

##### What went poorly?

Computer crashing was the worst part of the day because it rendered my laptop useless which in turn made me somewhat useless, I used the spare time jot down some notes on future developments so it wasn't all bad, I guess.

##### Comments?

#### Blockers

## Sprint 4 - Business Day Continued

### Sprint Review

##### What has been completed?

Today what has been completed are the complete revamp of the U.I, this includes 

- Student Login Page is now finished and ready for use
- Teacher Login Page is now finished and ready for use
- Teacher Login Page Links to Teacher Profile
- Student Login Page Links to Student Profile
- Student Profile Links To Enrolment Page
- No functionality in said pages have been implemented

##### Problems and Solutions?

Main problem is that my scope is too big, I was not focused enough on how the plan was set, too ambitious to see how the program works, I don't have the expertise / skill in order to easily turn my thoughts and ideas into practical work. The solution for this is to quickly rescope my project and make it more focused on one system. The one system I have chosen is the enrolment system in which students will be able to apply for enrolment after creating an account and logging in, they will also be able to see their profile page that contains their personal sensitive data.

##### What should come next?

Next should be the functionality / queries that come with the different pages. I plan on testing as I go but because i am pressed for time the testing will be limited to core functionality that are different from each other. 

### Sprint Retrospective

##### What went well?

Assessing my shortcomings and being able to move forward is a big step for me and even though it is a bit late its better than getting to the final sprints and trying to change the base of my project.

##### What went poorly?

The planning of the project in general was flawed, but this is a good stepping stone for the future where I **will not** be making the same mistakes

##### Comments?

the plan has changed from sprint 3's suggestions, because as I was working the program I noticed that the scale of the project is too big not only for the time limit we have but also for the level of skill I have using XAML, MVVM and just WPF in general.

#### Blockers

## Sprint 5 - Test Day

![](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\Sprint5\9.png)

![10](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\Sprint5\10.png)

### Sprint Review

##### What has been completed?

Today the sprint was left incomplete, the things that were completed are as follows

- Course Search Feature and Tested
- Course list display (relevant) 
- Teacher Registration
- Student and Teacher profile access 
- Methods to populate student data

please note that some of these had been done before but had to get redone so that they could work with the new scope that has been made

Incomplete today was searching for student records, this failed the sprint because I am not sure that it is needed in the program.

##### Problems and Solutions?

No real problems apart from my everlasting struggle with WPF / XAML, I am getting better though, Binding is pivotal for what I need to get done.

##### What should come next?

next there needs to be break to test some functionality that the program is using.

### Sprint Retrospective

##### What went well?

Today I found a good groove and a steady working pace, managed to get a lot of tricky things complete without wasting too much time, even had to create 1 or 2 unit tests

##### What went poorly?

##### Comments?

#### Blockers

## Sprint 6 - Struggle Day

![11](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\11.png)

![12](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\12.png)

### Sprint Review

##### What has been completed?

Today has been a slow day at the office as yet again the sprint did not get completed, todays completed list goes as follows,

- Enrolment system - students can now apply for a course  
- Profile edit for Teachers & Students

##### Problems and Solutions?

Big problem I keep getting conversion error when I am trying to query my database, worst part is that I have no idea what the problem could be.

##### What should come next?

Fixing this error

##### ![2021-05-18 (14)](C:\Users\phant\Documents\SchoolApp\SchoolApplication\SchoolApp\Images\2021-05-18 (14).png)



![2021-05-18 (15)](C:\Users\phant\Documents\SchoolApp\SchoolApplication\SchoolApp\Images\2021-05-18 (15).png)



### Sprint Retrospective

##### What went well?

##### What went poorly?

The testing with the querying methods went poorly, I barely managed to get any of them working, there is a bug I am overlooking but I don't know where

##### Comments?

The bug may be in the database...

#### Blockers

Conversion Error

## Sprint 7 - D Day

![13](C:\Users\phant\Documents\SchoolApp\SchoolApplication\Sprint Pics\13.png)

### Sprint Review

##### What has been completed?

- Final tests have been completed 
- The project is well rounded off

##### Problems and Solutions?

I managed to fix to conversion error, there was a bigInt in the database which was corrupting everything, the database still has some issues, especially concerning many to many relationships but the core functionality still works despite these problems

##### What should come next?

Next the documentation needs to be in order to document my journey using WPF to make an app for the first time.

### Sprint Retrospective

##### What went well?

What went well in the project was the fact that I learnt A lot, from understanding MVVM to learning and using bindings in my work to sync the c# language with the XAML. other than that I really enjoyed making this app, turning nothing into something has always been a pleasure of mine. The end product did not turn out anywhere near how i woulda have thought but that is because of poor planning due to lack of knowledge and high and ambition.

##### What went poorly?

I have to say, had I planned it better a not bit off more than I could chew this project would have ended up my better. the planning is my biggest flaw and had I the chance to go over it again I would have researched more so that I could come with a structure create to create the project, I feel that this would have given me more control over my project therefore giving me more freedom to be creative and show it in my programming.

Another thing is my database design, somewhere in my database there is a fatal flaw and one of the linked tables just dont work at all, which is mostly why my project has any issues, that being said working on database work in the future maybe beneficial for my understanding, and moving forward I will practise exactly that.

##### Comments?

There is not enough time to finish the implementation of everything but the main functions have been implemented

#### Blockers

# Further Improvements

This is just a small portion of what a school system can be so there many improvements that can be made to the finished product

1. Teacher can have more of an input, in this project teachers can only view things and only edit their own information as I build upon this app I will focus more on the teachers functionality as teachers should have more control over their courses and departments and need to have a say in who can enter and who cant and not just rely on algorithms
2. Students should be able to do more than just enrol, they should be given a timetable with their scheduled classes inside they should also be able to send messages to fellow peers / students
3. The overall look of the app is not unified and gives a distorted feeling. Apps should have a default layout where people can look at it and recognize immediately what it is.