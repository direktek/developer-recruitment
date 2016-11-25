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

Use the same output from Exercise 1 and include the Invoice number, Company Name, Invoice SubTotal, Invoice Total.

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

Extra Credit
--
- Write sql statements to create backing tables for Invoice and Invoice Item.
- Improve the user interface with a menu, searching and editing.
- Save the invoice data generated to a file on exit and then read in the file (if avaliable) on next startup.
