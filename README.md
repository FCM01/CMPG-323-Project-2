# cmpgAPI
# IMPORTANT FOR TESTING PLEASE READ THE FOLOWING
<h1>PLESE NOTE ALL DELETE METHODS REQUIRE ADMIN JWT /ACCESS TO BE USED </h1>
<h1>PLEASE NOTE THAT ALL ENDPOINTS EXCULDING THE Authenticate ENDPOINTS REQUIRE AUTHARIZATION TO BE USED PLEASE LOGIN FIRST BEFORE ANY TESTING CAN OCCUR </h1>
<h1>PLESE LOOK AT THE VALUES ENDPOINTS AS THEY CONTAIN THE ADDITIONAL METHODS THAT WERE ASKED FOR</h1>

# User Manual 
<p>Is a Restful API used to mansage Iot devices that utilizes CRUD methods </p>
<h1>How to obtain API</h1>
<h2>Option 1 </h2>
<p>You can use the git repository close and run the project loally </p>
<h2>Option 2 </h2>
<p>You can use the API manger on the Azure </p>


<h1>Endpoints</h1>
<h2>Authenticate</h2>
<br>
<p>The endpoints are used for the creation of users and admin users ,and the login of those respective users this login interaction wil provide a JWT that will allow a user to interact with the rest of the application</p>
<img src = "resources/Screenshot 2022-09-08 145233.png"></img>
<p>PLESE NOTE ALL DELETE METHODS REQUIRE ADMIN JWT /ACCESS TO BE USED </p>
<p>PLEASE NOTE THAT ALL ENDPOINTS EXCULDING THE Authenticate ENDPOINTS REQUIRE AUTHARIZATION TO BE USED PLEASE LOGIN FIRST BEFORE ANY TESTING CAN OCCUR </p>
<h2>CategoriesManagement</h2>
<br>
<p>The end points that are here are used to implement CRUD metods with the Category table in the SQL Database</p>
<img src = "resources/Screenshot 2022-09-08 145522.png"></img>
<p>PLESE NOTE ALL DELETE METHODS REQUIRE ADMIN JWT /ACCESS TO BE USED </p>
<p>PLEASE NOTE THAT ALL ENDPOINTS EXCULDING THE Authenticate ENDPOINTS REQUIRE AUTHARIZATION TO BE USED PLEASE LOGIN FIRST BEFORE ANY TESTING CAN OCCUR </p>
<h2>DeviceManagement</h2>
<br>
<p>The end points that are here are used to implement CRUD metods with the Device table in the SQL Database</p>
<img src = "resources/Screenshot 2022-09-08 145608.png"></img>
<p>PLESE NOTE ALL DELETE METHODS REQUIRE ADMIN JWT /ACCESS TO BE USED </p>
<p>PLEASE NOTE THAT ALL ENDPOINTS EXCULDING THE Authenticate ENDPOINTS REQUIRE AUTHARIZATION TO BE USED PLEASE LOGIN FIRST BEFORE ANY TESTING CAN OCCUR </p>
<h2>Zones</h2>
<br>
<p>The end points that are here are used to implement CRUD metods with the Device table in the SQL Database</p>
<img src = "resources/Screenshot 2022-09-08 145649.png"></img>
<p>PLESE NOTE ALL DELETE METHODS REQUIRE ADMIN JWT /ACCESS TO BE USED </p>
<p>PLEASE NOTE THAT ALL ENDPOINTS EXCULDING THE Authenticate ENDPOINTS REQUIRE AUTHARIZATION TO BE USED PLEASE LOGIN FIRST BEFORE ANY TESTING CAN OCCUR </p>
<h2>Values</h2>
<br>
<p>The endpoint located here are mainly used for the special GET methods that were asked for in the project description</p>
<p>The methods that are spoken off are:</p>
<ul>
<li>Create a GET method that will return the number of zones that are associated to a specific category (use the device entity to join the data)</li>
<li>Create a GET method that retrieves all devices within a specific zone (based on the zone ID that is parsed through)</li>
<li>Add a private method in the API that checks if a Device exists (based on the ID parsed through) before editing or deleting an item</li>
</ul>
<img src = "resources/Screenshot 2022-09-08 145734.png"></img>
<p>PLESE NOTE ALL DELETE METHODS REQUIRE ADMIN JWT /ACCESS TO BE USED </p>
<p>PLEASE NOTE THAT ALL ENDPOINTS EXCULDING THE Authenticate ENDPOINTS REQUIRE AUTHARIZATION TO BE USED PLEASE LOGIN FIRST BEFORE ANY TESTING CAN OCCUR </p>





