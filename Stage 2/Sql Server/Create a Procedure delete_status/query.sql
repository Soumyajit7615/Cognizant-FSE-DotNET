CREATE PROCEDURE delete_status
@status_id INT
AS 
BEGIN
	IF EXISTS(SELECT * FROM agent WHERE id = @status_id)
	BEGIN
		INSERT INTO status_error_log(error_msg)
		VALUES('child records existing in claims table');
	END

	ELSE IF EXISTS(SELECT * FROM address WHERE id = @status_id)
	BEGIN
		INSERT INTO status_error_log(error_msg)
		VALUES('child records existing in claims table');
	END

	ELSE IF EXISTS(SELECT * FROM insurance_company WHERE id = @status_id)
	BEGIN
		INSERT INTO status_error_log(error_msg)
		VALUES('child records existing in claims table');		
	END
	
	ELSE IF EXISTS(SELECT * FROM customer WHERE id = @status_id)
	BEGIN
		INSERT INTO status_error_log(error_msg)
		VALUES('child records existing in claims table');
	END
	
	ELSE IF EXISTS(SELECT * FROM customer_policy WHERE id = @status_id)
	BEGIN
		INSERT INTO status_error_log(error_msg)
		VALUES('child records existing in claims table');
	END
	
	ELSE IF EXISTS(SELECT * FROM policy WHERE id = @status_id)
	BEGIN
		INSERT INTO status_error_log(error_msg)
		VALUES('child records existing in claims table');
	END
	
	ELSE IF EXISTS(SELECT * FROM claims WHERE id = @status_id)
	BEGIN
		insert into status_error_log(error_msg) values("child records existing in claims table");
	END
	
	ELSE
	BEGIN
		DELETE FROM status WHERE id = @status_id
	END
END
GO
