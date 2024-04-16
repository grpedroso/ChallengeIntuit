
Customer Registration API Project
This is a project of an API developed in C# that allows the registration of customers in a SQL Server database. The API provides endpoints to perform basic CRUD (Create, Read, Update, Delete) operations on customer data.

Features
Registration of new customers
Querying registered customers
Updating information of existing customers
Deleting customers from the database
Configuration
Clone this repository to your local machine.
Make sure you have installed all necessary dependencies.
Configure necessary environment variables, such as the database connection string.
Run the API server.

Usage
After configuring and starting the API, you can perform the following operations:

To register a new customer, make a POST request to /Clientes with the customer data in the request body.
To query all registered customers, make a GET request to /Clientes.
To query a specific customer by ID, make a GET request to /Clientes/{id}.
To search for customers by name, make a GET request to /Clientes/BuscarPorNombre/{nombre}.
To update the data of an existing customer, make a PUT request to /Clientes with the new customer data in the request body.
To delete a customer from the database, make a DELETE request to /Clientes/{id}.
Make sure to replace {id} with the desired customer's unique identifier and {nombre} with the desired customer's name.

Contributing
Contributions are welcome! Feel free to open a pull request to propose improvements or fixes.

Authors
Gabriel Rinco Pedroso
