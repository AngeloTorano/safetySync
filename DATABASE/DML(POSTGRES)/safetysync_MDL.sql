SELECT * FROM province;

SELECT * FROM hotline;

SELECT * FROM cashistory;


UPDATE cashistory
SET "columnName" = @editedValue
WHERE "catastrophicHistory_id" = @ID;

INSERT INTO cashistory("disasterEvent", "catastrophicHistory", "category", "provinceName", "province_id")
VALUES (@event, @history, @category, @province, @ID);

INSERT INTO hotline (agency, hotlineNumber, provinceName, province_id)
VALUES (@agency, @hotlineNum, @province, @ID);

INSERT INTO admin_accounts (name, adminusername, adminpassword)
VALUES (@name, @username, @password);
	
DELETE FROM cashistory WHERE hotline_id = @ID;

DELETE FROM hotline WHERE catastrophicHistory_id = @ID;

INSERT INTO hotline (agency, hotlineNumber, provinceName, province_id)
VALUES (@agency, @hotlineNum, @province, @ID);

SELECT
    province.province_id,
    province.provinceName,
    COUNT(DISTINCT hotline.hotlineNumber) AS hotlineCount,
    COUNT(DISTINCT hotline.agency) AS agencyCount,
    COUNT(DISTINCT cashistory.catastrophicHistory) AS cashistoryCount
FROM
    province
INNER JOIN
	hotline ON province.province_id = hotline.province_id
INNER JOIN
    cashistory ON province.province_id = cashistory.province_id
GROUP BY
    province.province_id,
    province.provinceName
ORDER BY
    province.provinceName;



