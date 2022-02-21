/* 
Name - Joseph Mendez
UTSA ID - qxo307
Course - IS.6503.001

Question 19
SELECT AVG(prod_price) FROM lgproduct
	displays the AVG price of all the products in lgproduct

a) Query that displays products that have a price > the average
		price of all products in th elgproduct table */
SELECT prod_sku, prod_descript, prod_price FROM lgproduct
WHERE prod_price > (SELECT AVG(prod_price) FROM lgproduct);

/* b) Query that displays the brands that have a brand average price
		> than the average price of all products */
SELECT brand_id, AVG(prod_price) as 'brand_p_avg' FROM lgproduct
GROUP BY brand_id
HAVING AVG(prod_price) > (SELECT AVG(prod_price) FROM lgproduct);

/* c) Query that displays the products that have a price higher than
		the average price of products from the same brand */
SELECT prod_sku, prod_descript, brand_id, prod_price
FROM lgproduct P 
WHERE P.prod_price > (SELECT AVG(prod_price) FROM lgproduct P2 
	WHERE P.brand_id = P2.brand_id);


/* Question 20
Query that displays the current salary for each employee in dept. 300 
	sorted in a descending order by salary amount */
SELECT E.emp_num, emp_lname, emp_fname, sal_amount 
FROM lgsalary_history SH JOIN lgemployee E on E.emp_num = SH.emp_num
WHERE dept_num = 300
AND sal_end IS NULL
ORDER BY SH.sal_amount DESC;


/* Question 21
Query that displays the starting salary for each employee sorted by
		employee number */
SELECT E.emp_num, MAX(emp_lname) as emp_lname, MAX(emp_fname) 
	as emp_fname, MIN(sal_amount) as sal_amonut
FROM lgemployee E JOIN lgsalary_history S on E.emp_num = S.emp_num
GROUP BY E.emp_num
ORDER BY E.emp_num, MIN(emp_hiredate);


/* Question 22
Query that displays the invoice number, line numbers, product SKUs,
		product descriptions, and brand ID for sales of sealer and top
		coat products of the same brand on the same invoice*/
SELECT L.inv_num, L.line_num, P.prod_sku, P.prod_descript,
	MI.line_num as l2_line_num, MI.prod_sku as p2_prod_sku,
	MI.prod_descript as p2_prod_sku, P.brand_id
FROM (SELECT L2.inv_num as inv_num, L2.line_num as line_num, 
		P2.prod_sku as prod_sku, P2.prod_descript as prod_descript, 
		P2.prod_category as prod_category,
		P2.brand_id as brand_id
		FROM lgline L2
		JOIN lgproduct P2 on L2.prod_sku = P2.prod_sku
		WHERE P2.prod_category = 'top coat') MI, 
	 lginvoice IV
JOIN lgline L on IV.inv_num = L.inv_num
JOIN lgproduct P on L.prod_sku = P.prod_sku
WHERE P.prod_category = 'sealer' 
	AND L.prod_sku != MI.prod_sku
	AND P.brand_id = MI.brand_id
	AND MI.inv_num = L.inv_num
ORDER BY L.inv_num ASC;


/* Question 23
Query that displays employee number, emloyee first name, employee last name,
		e-mail, and total units sold for the employee who sold the most
		Binder Prime brand between Nov 1st 2011 and Dec 5th, 2011 */
SELECT E3.emp_num, emp_fname as emp_fname, emp_lname as emp_lname,
	emp_email as emp_email, INFO_2.total as totals
FROM (SELECT INFO.emp_num, MAX(INFO.sumtotal) as total
	FROM (SELECT emp_num, SUM(L2.line_qty) as sumtotal
			FROM lgemployee E2
			JOIN lginvoice IV2 on IV2.employee_id = E2.emp_num
			JOIN lgline L2 on L2.inv_num = IV2.inv_num
			JOIN lgproduct P2 on P2.prod_sku = L2.prod_sku
			JOIN lgbrand B2 on B2.brand_id = P2.brand_id
			WHERE B2.brand_name = 'Binder Prime'
				AND (IV2.inv_date BETWEEN '11-01-2011' AND '12-05-2011')
			GROUP BY E2.emp_num) INFO, 
		lgemployee E
	WHERE E.emp_num = INFO.emp_num
	GROUP BY INFO.emp_num) INFO_2, lgemployee E3
WHERE INFO_2.emp_num = E3.emp_num
AND INFO_2.total = (SELECT MAX(INFO.sumtotal) as total
	FROM (SELECT emp_num, SUM(L2.line_qty) as sumtotal
			FROM lgemployee E2
			JOIN lginvoice IV2 on IV2.employee_id = E2.emp_num
			JOIN lgline L2 on L2.inv_num = IV2.inv_num
			JOIN lgproduct P2 on P2.prod_sku = L2.prod_sku
			JOIN lgbrand B2 on B2.brand_id = P2.brand_id
			WHERE B2.brand_name = 'Binder Prime'
				AND (IV2.inv_date BETWEEN '11-01-2011' AND '12-05-2011')
			GROUP BY E2.emp_num) INFO, 
		lgemployee E
	WHERE E.emp_num = INFO.emp_num)
ORDER BY E3.emp_lname ASC


/* Question 24
Query that displays the customer code, first name, and last name
		of cusomters who ahve at least one invoice completed by
		employee 83649 and at least one invoice completed by employee
		83677 */
SELECT *
FROM (SELECT C.cust_code, C.cust_fname, C.cust_lname
			FROM lgcustomer C
			JOIN lginvoice IV on IV.cust_code = C.cust_code
			JOIN lgemployee E on E.emp_num = IV.employee_id
			WHERE IV.employee_id = 83649
	INTERSECT
	SELECT C.cust_code, C.cust_fname, C.cust_lname
			FROM lgcustomer C
			JOIN lginvoice IV on IV.cust_code = C.cust_code
			JOIN lgemployee E on E.emp_num = IV.employee_id
			WHERE IV.employee_id = 83677) INFO
ORDER BY cust_lname, cust_fname


/* Question 25
Query that displays customer code, customer first name, customer last name
		full address, invoice date, and invoice total of the largest
		purchase made by each customer in Alabama */
SELECT *
FROM (SELECT *
		FROM (SELECT C.cust_code, C.cust_fname, C.cust_lname, MAX(C.cust_street) as cust_street, 
			MAX(C.cust_city) as cust_city, MAX(C.cust_state) as cust_state, MAX(C.cust_zip) as cust_zip,
			FORMAT(MAX(IV.inv_date),N'M"/"dd"/"yy', 'en-US') as inv_date, MAX(IV.inv_total) as inv_total
		FROM lgcustomer C
		JOIN lginvoice IV on IV.cust_code = C.cust_code
		GROUP BY C.cust_code, C.cust_fname, C.cust_lname) INFO
	WHERE INFO.cust_state = 'AL'
	UNION ALL
	SELECT C2.cust_code, C2.cust_fname, C2.cust_lname, C2.cust_street, 
		C2.cust_city, C2.cust_state, C2.cust_zip,
		FORMAT(IV2.inv_date,N'M"/"dd"/"yy', 'en-US'), IV2.inv_total as inv_total
	FROM lgcustomer C2
	JOIN lginvoice IV2 on IV2.cust_code = C2.cust_code
	WHERE C2.cust_state = 'AL'
	AND IV2.inv_date is NULL
	AND IV2.inv_total = 0
	GROUP BY C2.cust_code, C2.cust_fname, C2.cust_lname, C2.cust_street, 
		C2.cust_city, C2.cust_state, C2.cust_zip, IV2.inv_date, IV2.inv_total) INFO_2
ORDER BY INFO_2.cust_lname

/* Question 26
Query that displays brand name, brand type, average price, and total
		units sold of products of each brand */
SELECT B.brand_name, B.brand_type, FORMAT((AVG(P.prod_price)),'N2') 
	as average_price, SUM(L.line_qty) as units_sold
FROM lgproduct P
JOIN lgbrand B on B.brand_id = P.brand_id
JOIN lgline L on P.prod_sku = L.prod_sku
GROUP BY B.brand_name, B.brand_type
ORDER BY B.brand_name


/* Question 27
Query that displays the brand name, brand type, product SKU, product
		description, and price of any product that is not a premium
		brand and costs more than the most expensice premium brand */
SELECT B.brand_name, B.brand_type, P.prod_sku, P.prod_descript, P.prod_price
FROM lgbrand B
JOIN lgproduct P on P.brand_id = B.brand_id
WHERE P.prod_price > (SELECT MAX(P2.prod_price) FROM lgbrand B2
JOIN lgproduct P2 on P2.brand_id = B2.brand_id  
	WHERE brand_type = 'Premium')