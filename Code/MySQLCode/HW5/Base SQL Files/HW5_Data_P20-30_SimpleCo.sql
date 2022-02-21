-- Note that since both customer and invoice tables appear in the dataset for P31-34, 
-- it is recommended that you create two different databases to develop the queries. 
-- However, you should only turn in one .sql file that contains all your queries. 

-- 16
CREATE TABLE CUSTOMER (
CUST_NUM     INTEGER PRIMARY KEY,
CUST_LNAME   VARCHAR(30),
CUST_FNAME   VARCHAR(30),
CUST_BALANCE DECIMAL(8,2));

-- 17
CREATE TABLE INVOICE (
INV_NUM    INTEGER PRIMARY KEY,
CUST_NUM   INTEGER,
INV_DATE   DATE,
INV_AMOUNT DECIMAL(10,2),
FOREIGN KEY (CUST_NUM) REFERENCES CUSTOMER(CUST_NUM));

-- 18
INSERT INTO CUSTOMER VALUES (1000, 'Smith', 'Jeanne', 1050.11);
INSERT INTO CUSTOMER VALUES (1001, 'Ortega', 'Juan', 840.92);

-- 19
INSERT INTO INVOICE VALUES (8000, 1000, '2016-03-23', 235.89);
INSERT INTO INVOICE VALUES (8001, 1001, '2016-03-23', 312.82);
INSERT INTO INVOICE VALUES (8002, 1001, '2016-03-30', 528.10);
INSERT INTO INVOICE VALUES (8003, 1000, '2016-04-16', 194.78);
INSERT INTO INVOICE VALUES (8004, 1000, '2016-04-23', 619.44);
