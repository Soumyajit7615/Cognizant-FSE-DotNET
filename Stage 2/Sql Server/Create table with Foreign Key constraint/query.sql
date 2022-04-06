CREATE TABLE orders(
    ORD_NO numeric(5), 
    PURCH_AMT decimal(8,2),
    ORD_DATE date,
    CUSTOMER_ID numeric(5),
    SALESMAN_ID numeric(5),
    PRIMARY KEY (ORD_NO), 
    FOREIGN KEY(SALESMAN_ID) REFERENCES SALESMAN(SALESMAN_ID)
)
GO
