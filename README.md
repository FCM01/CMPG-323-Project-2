# cmpgAPI
# IMPORTANT FOR TESTING PLEASE READ THE FOLOWING
<h3>PLESE NOTE ALL DELETE METHODS REQUIRE ADMIN JWT /ACCESS TO BE USED </h3>
<h3>PLEASE NOTE THAT ALL ENDPOINTS EXCULDING THE Authenticate ENDPOINTS REQUIRE AUTHARIZATION TO BE USED PLEASE LOGIN FIRST BEFORE ANY TESTING CAN OCCUR </h3>
<h3>PLESE LOOK AT THE VALUES ENDPOINTS AS THEY CONTAIN THE ADDITIONAL METHODS THAT WERE ASKED FOR</h3>

# User Manual 
<p>Is a Restful API used to mansage Iot devices that utilizes CRUD methods </p>
<h1>How to obtain API</h1>
<h2>Option 1 </h2>
<p>You can use the git repository close and run the project loally </p>
<h2>Option 2 </h2>
<p>You can use the API manger on the Azure </p>


# Endpoints
<h2>Authenticate</h2>
<br>
<p>The endpoints are used for the creation of users and admin users and the login of those respective users. This login interaction will provide a JWT that will allow a user to interact with the rest of the application.</p>
<img src = "resources/Screenshot 2022-09-08 145233.png"></img>
<p>Use of the Authenticate-Login endpoint will give the user the following JWT, which can be used to authenticate them on this API and use it.</p>
<img src = "Screenshot 2022-09-08 150817.png"></img>
<p>PLESE NOTE ALL DELETE METHODS REQUIRE ADMIN JWT /ACCESS TO BE USED </p>
<p>PLEASE NOTE THAT ALL ENDPOINTS EXCULDING THE Authenticate ENDPOINTS REQUIRE AUTHARIZATION TO BE USED PLEASE LOGIN FIRST BEFORE ANY TESTING CAN OCCUR </p>
<h2>CategoriesManagement</h2>
<br>
<p>The end points that are here are used to implement CRUD methods with the Category table in the SQL Database.</p>
<img src = "resources/Screenshot 2022-09-08 145522.png"></img>
<p>PLESE NOTE ALL DELETE METHODS REQUIRE ADMIN JWT /ACCESS TO BE USED </p>
<p>PLEASE NOTE THAT ALL ENDPOINTS EXCULDING THE Authenticate ENDPOINTS REQUIRE AUTHARIZATION TO BE USED PLEASE LOGIN FIRST BEFORE ANY TESTING CAN OCCUR </p>
<h2>DeviceManagement</h2>
<br>
<p>The end points that are here are used to implement CRUD methods with the Device table in the SQL Database.</p>
<img src = "resources/Screenshot 2022-09-08 145608.png"></img>
<p>PLESE NOTE ALL DELETE METHODS REQUIRE ADMIN JWT /ACCESS TO BE USED </p>
<p>PLEASE NOTE THAT ALL ENDPOINTS EXCULDING THE Authenticate ENDPOINTS REQUIRE AUTHARIZATION TO BE USED PLEASE LOGIN FIRST BEFORE ANY TESTING CAN OCCUR </p>
<h2>Zones</h2>
<br>
<p>The end points that are here are used to implement CRUD methods with the Zones table in the SQL Database.</p>
<img src = "resources/Screenshot 2022-09-08 145649.png"></img>
<p>PLESE NOTE ALL DELETE METHODS REQUIRE ADMIN JWT /ACCESS TO BE USED </p>
<p>PLEASE NOTE THAT ALL ENDPOINTS EXCULDING THE Authenticate ENDPOINTS REQUIRE AUTHARIZATION TO BE USED PLEASE LOGIN FIRST BEFORE ANY TESTING CAN OCCUR </p>
<h2>Values</h2>
<br>
<p>The endpoints located here are mainly used for the special GET methods that were asked for in the project description. I made this controller (Value Controller)because I was unable to edit the Category and ZOne Controllers to add the required GET methods, so I made my own, which in turn fixed the issue I was experiencing.</p>
<img src = "resources/Screenshot 2022-09-08 145734.png"></img>

<p>The methods that are spoken off are:</p>
<ul>
<li>Create a GET method that will return the number of zones that are associated to a specific category (use the device entity to join the data)</li>
<img src = "resources/Screenshot 2022-09-08 151503.png"></img>

<li>Create a GET method that retrieves all devices within a specific zone (based on the zone ID that is parsed through)</li>
<img src = "resources/Screenshot 2022-09-08 151314.png"></img>
<li>Add a private method in the API that checks if a Device exists (based on the ID parsed through) before editing or deleting an item</li>
<img src = "resources/Screenshot 2022-09-08 151810.png"></img>
</ul>
<h1>API MANAGER SCREENSHOTS</h1>
<p>Endpoints are below:</p>
<img src = "resources/Screenshot 1.png"></img>
<img src = "resources/Screenshot 2.png"></img>
<p>PLESE NOTE ALL DELETE METHODS REQUIRE ADMIN JWT /ACCESS TO BE USED </p>
<p>PLEASE NOTE THAT ALL ENDPOINTS EXCULDING THE Authenticate ENDPOINTS REQUIRE AUTHARIZATION TO BE USED PLEASE LOGIN FIRST BEFORE ANY TESTING CAN OCCUR </p>





