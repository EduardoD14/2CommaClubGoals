
# <pre>      ![SmallLogo](https://user-images.githubusercontent.com/47153835/56347974-56b33400-617a-11e9-90e6-6500cf8f6795.png)
# 2CommaClubGoals 
### Too many of us do not know how to manage our finances. There are too many secrets that the banks and wealthy do not share. It is time to start our journey to the 2 Comma Club

*I have purchased http://2commaclubgoals.com/ but I am not running the site on this domain in a way to minimize costs in the steps prior to the website launch. To view the website  in it's current state go to http://2commaclubgoals.azurewebsites.net/*

##  Table of Contents
|Location|Content                        |
|:--- | ---- |
| 1.   | [Domain](https://github.com/EduardoD14/2CommaClubGoals/blob/master/README.md#2CommaClubGoals)									   |
| 1.1  | [PowerPoint Presentation - Latest Version](https://github.com/EduardoD14/2CommaClubGoals/blob/master/2CommaClubGoals.pdf)				   |
| 1.2  | [Requirement Traceability Matrix](https://github.com/EduardoD14/2CommaClubGoals/blob/master/README.md#DesignOutlook/Requirements)			   |
|2.   | [Database Design](https://github.com/EduardoD14/2CommaClubGoals/blob/master/README.md#Database-Design)				 |
| 2.1  | [Table Scripts](https://github.com/EduardoD14/2CommaClubGoals/blob/master/README.md#Database-Design)|
| 2.2  | [Class Diagram](https://github.com/EduardoD14/2CommaClubGoals/blob/master/README.md#class-diagram-from-entity-framework-datamodel)			  |
| 3.   | [WireFrames](https://github.com/EduardoD14/2CommaClubGoals/blob/master/README.md#WireframesScreenshots)									  |
| 3.1  | [Contact page](https://github.com/EduardoD14/2CommaClubGoals/blob/master/README.md#contact-page)	|
| 3.   | [Prioritized Backlog Items](https://github.com/EduardoD14/2CommaClubGoals/blob/master/README.md#Prioritized-Backlog-Items)						  |
| 4.   | [Tests](https://github.com/EduardoD14/2CommaClubGoals/blob/master/README.md#tests)															  |
| 4.1  | [Unit Test](https://github.com/EduardoD14/2CommaClubGoals/blob/master/README.md#tests)						  |

## PowerPoint Presentation

![image](https://user-images.githubusercontent.com/47153835/56358400-57a48f80-6193-11e9-807c-4b3c56aacd64.png)

#### <center>                [Link to Latest PowerPoint Presentation](https://github.com/EduardoD14/2CommaClubGoals/blob/master/2CommaClubGoals.pdf)

###  <center> Traceability Matrix

| ID | Requirements   | How?      | Being Met?  | Unit Test Passing? |
|:---| -------------- |-----------|----------------| ------------------ |
| 1 | Aesthetic Design | CSS & JavaScript | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 1.1 | Web Application Dynamic & Interactive | JavaScript |  <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 1.2 | Styling Uniform & Pleasing To App owner | CSS | <ul><li> - [ ] </li></ul> |	<ul><li> - [ ] </li></ul> |
| 1.3 | Mobile Responsive Design | JavaScript & CSS | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 1. 4 | Intuitive URLS | MVC config | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 2  | Contact Photographer| Partial View, SMTP, CSS, JavaScript & DB | <ul><li> - [ ] </li></ul> |	<ul><li> - [ ] </li></ul> |
| 2.1 | Form for Client to Fill | Partial View, CSS, DB, SMTP & JavaScript | <ul><li> - [x] </li></ul> |	<ul><li> - [ ] </li></ul> |
| 2.1.1  | Email Sent to Photographer After Form Filled | SMTP | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 2.1.2  | Form Design Logical Ex: Textbox Sizes | CSS | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 2.1.3  | Logging Potential Clients to Database (DB) |  Database (DB) | <ul><li> - [x] </li></ul> |	<ul><li> - [ ] </li></ul> |
| 2.1.4 | Requirements Set in Front-End and Back-End | JavaScript, [Requirements] | <ul><li> - [ ] </li></ul> |	<ul><li> - [ ] </li></ul> |
| 2.2  | Potential Clients Accessed Directly From Website if Photographer is Logged In | Partial View Using DB | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 3  | Blog page | Azure BLOB containers, JavaScript & DB  | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 3.1  | CRUD operations | Azure BLOB & DB  | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 3.1.1 |  Photographer Is Able To Create new blogs with images and text | Azure BLOB containers & DB | <ul><li> - [ ] </li></ul> |	<ul><li> - [ ] </li></ul> |
| 3.1.2 |  Photographer Is Able To Read Update & Delete Blogs with Images & Text | Azure BLOB containers & DB | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 3.2  | Users Can View and Comment On Blog | Azure BLOB containers & DB | <ul><li> - [ ] </li></ul> |	<ul><li> - [ ] </li></ul> |
| 3.3 | Requirements Set in Front-End and Back-End | JavaScript, [Requirements] | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 4 | Portfolio Page | Azure BLOB & JavaScript | <ul><li> - [ ] </li></ul>|	<ul><li> - [ ] </li></ul> |
| 4.1  | Portfolio Where Containers for Different Types of Shoots are Displayed Ex: Faces, Events, and Family | Azure BLOB | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 4.2 | Photographer Able to CRUD Portfolio Containers | Azure BLOB | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 4.3 | Requirements Set in Front-End and Back-End | JavaScript, [Requirements] | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 5 | Shop (Shop and Rates+Packages View) | Azure BLOB, DB, SSL, JavaScript, and Views  | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 5.1  | photographer Able to CRUD Purchase Product Images | Azure BLOB & DB | <ul><li> - [ ] </li></ul> |	<ul><li> - [ ] </li></ul> |
| 5.2  | Clients Able to Purchase tangible products Directly on App | SSL and  Cart & CheckOut Views| <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
|  5.3 | Photographer Able to CRUD Rates+Packages for Small Photoshoots Directly on App | DB | <ul><li> - [ ] </li></ul> |	<ul><li> - [ ] </li></ul> |
| 5.4 | Clients Able to Purchase Small Photoshoots Directly on App | SSL , Cart, Checkout, DB, & JavaScript | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 5.4.1 | Client Able to Choose Date and Time Availability From Calendar | JavaScript | <ul><li> - [ ] </li></ul>| 	<ul><li> - [ ] </li></ul> |
| 5.4.1.1 | Once Purchased Slot is Filled and No Other Photoshoots Can Be Purchased in 1  hour +/- window | DB | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 5.5 | Requirements Set in Front-End and Back-End | JavaScript, [Requirements] | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 6 | About Me to Get a Closer Feel for Photographer/s | View Accessed through Homepage, JavaScript & DB | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 6.1 | CRUD Operations for Photographer/s | DB | <ul><li> - [ ] </li></ul>| <ul><li> - [ ] </li></ul> |
| 6.2 | Requirements Set in Front-End and Back-End | JavaScript, [Requirements] | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 7 | Testimonies/Reviews | Partial View, JavaScript,  & DB | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 7.1 | Previous and New Clients Able to Create Reviews | Separate View Accessed From Homepage & using DB | <ul><li> - [ ] </li></ul> |	<ul><li> - [ ] </li></ul> |
| 7.1.1 | Requirements Set in Front-End and Back-End | JavaScript, [Requirements] | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 7.2 | Clients Able to Tie Reviews To Their Photoshoots | Drop Down of Active Photoshoots with no reviews (JavaScript  & DB) | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
|7.2.1 | If photographer Wants To Tie Reviews To Images then they are displayed on HomePage | DB | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 7.2.1 | Client Claiming Photoshoot Verified by Photographer | Admin & Verification Partial View | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 7.3 | Testimonies on Homepage | Partial View Using DB | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 8 | Highly Cohesive & Loosely Coupled | OOP | <ul><li> - [x] </li></ul> | <ul><li> - [ ] </li></ul> |
| 8.1 | Business Logic Layer, Data Access Layer, & UI Layer Architecture Clearly Defined & Implemented | OOP | <ul><li> - [x] </li></ul> | <ul><li> - [ ] </li></ul> |
| 9  | Hidden Photographer Account Login/Register Page to Change/Add App Content | Hidden View, DataAnnotations, JavaScript, SSL, & DB | <ul><li> - [ ] </li></ul> |<ul><li> - [ ] </li></ul> |
| 9.1| Easy/Intuitive *hidden* URL to Access Account Login | Hidden View | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 9.2 | Data Annotations Represent Register Form and DB Ex: [DataType(DataType.Password)] | DataAnnotations |<ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 9.3 | Requirements Set in Front-End and Back-End | JavaScript, [Requirements] | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 9.3.1 | Requirements Accurate , Logical and Match DB  *Ex: Password Length 7 Character Minimum*  |DB, Common Sense| <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 9.4 | Password Hashed in DB | Hash | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 9.5 | SSL | Azure Settings (cost $) | <ul><li> - [ ] </li></ul>| N/A |
| 10 | Unit Test Written | Test Explorer | <ul><li> - [ ] </li></ul> | N/A |
| 11 | Deliverable Photographs | Link/Generator, Azure BLOB, DB, & Hashing | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 11.1 | Generating Random Links for Clients |  | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 11.1.1 | Links Hold Images On Containers Linked to Their Azure BLOB | Azure BLOB & DB | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |
| 11.2 | Safe-Access Key if Client Wants Their Images Secret | Hashed Key & DB | <ul><li> - [ ] </li></ul> | <ul><li> - [ ] </li></ul> |


## Database Design
![image](https://user-images.githubusercontent.com/47153835/56359453-78baaf80-6196-11e9-8855-4aab3cdea238.png)
### <center> [Take me to CreateTable Scripts](https://github.com/EduardoD14/2CommaClubGoals/blob/master/Making%20and%20Updating%20Users.sql) 

### Prerequisites

What things you need to install the software and how to install them

```
Give examples
```

### Installing

A step by step series of examples that tell you how to get a development env running

Say what the step will be

```
Give the example
```

And repeat

```
until finished
```

End with an example of getting some data out of the system or using it for a little demo

## Running the tests

Explain how to run the automated tests for this system

### Break down into end to end tests

Explain what these tests test and why

```
Give an example
```

### And coding style tests

Explain what these tests test and why

```
Give an example
```

## Deployment

Add additional notes about how to deploy this on a live system

## Built With

* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - The web framework used
* [Maven](https://maven.apache.org/) - Dependency Management
* [ROME](https://rometools.github.io/rome/) - Used to generate RSS Feeds

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Billie Thompson** - *Initial work* - [PurpleBooth](https://github.com/PurpleBooth)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc

