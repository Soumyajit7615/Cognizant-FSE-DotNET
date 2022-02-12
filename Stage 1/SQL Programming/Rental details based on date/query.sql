SELECT rental_id, car_id, customer_id, km_driven FROM rentals
WHERE EXTRACT(MONTH FROM pickup_date) = 8 AND EXTRACT(YEAR FROM pickup_date) = 2019
ORDER BY rental_id;
