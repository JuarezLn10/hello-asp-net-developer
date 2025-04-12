# User Stories 

This document contains technical stories for the 'hello-asp-net-developer' REST API from the perspective of a developer interacting with it through the API.

## TS001: Retrieve Greeting via GET Request
**As** a developer, 
**I want to** retrieve a greeting message by providing optional first and last names,
**so that** I can test the API with both named and anonymous inputs.

### Acceptance Criteria
- **Scenario 1: Anonymous Greeting**
  - **Given** a developer has not provided any names,
  - **When** the developer requests a greeting via GET,
  - **Then** the developer receives a response with a message "Welcome Anonymous ASP.NET Developer".
- **Scenario 2: Personalized Greeting**
  - **Given** a developer has provided a first name 'John' and last name 'Doe',
  - **When** the developer requests a greeting via GET,
  - **Then** the developer receives a response with a message "Congrats John Doe! You're now an ASP.NET Developer".
- **Scenario 3: Partial Name Greeting**
  - **Given** a developer has provided only a first name 'John',
  - **When** the developer requests a greeting via GET,
  - **Then** the developer receives a response with a message "Welcome Anonymous ASP.NET Developer".