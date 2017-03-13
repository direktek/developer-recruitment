Developer Test
================

Complete each exercise using the data provided by Repo.All(). Each call to this method randomly generates data.
You may change anything within this solution. Each exercise should be built upon the code of the previous exercise.

- When you have completed the exercises, zip up the solution and send it back via email.
- Please DO NOT fork this project on Github.

Exercise 1
--
Calculate the SubTotal and Total for InvoiceItems.

Output invoice number and all line item properties.

* InvoiceItem SubTotal; Will be equal to the UnitPrice * Quantity
* InvoiceItem Total; Will be equal to the SubTotal, minus the percentage based discount, and if line item is taxable apply the invoiced tax rate

Exercise 2
--
Calculate the SubTotal and Total for Invoice.

Use the same output from Exercise 1 and include the Invoice number, Company Name, Invoice SubTotal, Invoice Total. This view should allow the user to easily see all invoices.

* Invoice SubTotal; Will be equal to the summation of line items Total
* Invoice Total; will be equal to SubTotal plus the Shipping

Exercise 3
--
Add a new field to store commission amount for the invoice.
Commission must be calculated from the line item subtotal minus any discounts.
Commission rate is 3%.
Round the commission amount to the nearest 50 pence.

Use the same output from Exercise 2 and include the commission amount for each line and a total commission for the invoice.

* £10.25 = £10.00
* £10.30 = £10.50
* £10.60 = £10.50
* £10.90 = £11.00

Exercise 4 
--
Implement a new repository called JsonRepository for use instead of RandomRepository.
This repository should read in the data contained within the "invoices.json" file and construct Invoices and InoviceItems for use within the program.

Exercise 5
--
Add five new menu options to display each of the key stats:

* Top 10 selling SKUs and amounts sold of each
* Total tax to be collected
* Total revenue by SKU
* Average invoice value
* Top 5 selling SKUs per company

Exercise 6
--
Add a search interface.

Exercise 7
--
Write the SQL statements to create tables for Invoice and Invoice Item.