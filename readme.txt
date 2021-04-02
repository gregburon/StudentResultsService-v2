Download this code and build in Visual Studio. I used Visual Studio Community 2019.

You can build and run the application.  It should launch a browser when you do.  You navigate to:
  https://localhost:44375/api/StudentResults
  
  This will show that the service is up and running and that is the URL that can be connected to by clients to pull the student information / results.
  
  This RESTful web service is intended to be run with my other repo, student-course-results-app, which is a ReactJS app that pulls information from that URL and creates JSX / HTML to render the results from that RESTful API.
