SELECT INFO_2.cust_code, INFO_2.cust_fname, INFO_2.cust_lname, INFO_2.cust_street,
	INFO_2.cust_city, INFO_2.cust_state, INFO_2.cust_zip, INFO_2.cust_zip, 
	FORMAT(INFO_2.inv_total,N'M"/"dd"/"yy', 'en-US') as inv_date
FROM (SELECT *
		FROM (SELECT C.cust_code, C.cust_fname, C.cust_lname, MAX(C.cust_street) as cust_street, 
			MAX(C.cust_city) as cust_city, MAX(C.cust_state) as cust_state, MAX(C.cust_zip) as cust_zip,
			MAX(IV.inv_total) as inv_total
		FROM lgcustomer C
		JOIN lginvoice IV on IV.cust_code = C.cust_code
		GROUP BY C.cust_code, C.cust_fname, C.cust_lname) INFO
	WHERE INFO.cust_state = 'AL'
	UNION ALL
	SELECT C2.cust_code, C2.cust_fname, C2.cust_lname, C2.cust_street, 
		C2.cust_city, C2.cust_state, C2.cust_zip,
		IV2.inv_total as inv_total
	FROM lgcustomer C2
	JOIN lginvoice IV2 on IV2.cust_code = C2.cust_code
	WHERE IV2.inv_date is NULL
	AND IV2.inv_total = 0
	GROUP BY C2.cust_code, C2.cust_fname, C2.cust_lname, C2.cust_street, 
		C2.cust_city, C2.cust_state, C2.cust_zip, IV2.inv_date, IV2.inv_total) INFO_2
ORDER BY INFO_2.cust_lname
FORMAT(IV.inv_date,N'M"/"dd"/"yy', 'en-US') as inv_date