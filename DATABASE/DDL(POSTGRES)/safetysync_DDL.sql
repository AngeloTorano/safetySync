-- Table structure for table `admin_accounts`
CREATE TABLE IF NOT EXISTS admin_accounts (
  admin_id SERIAL PRIMARY KEY,
  name VARCHAR(100) NOT NULL,
  adminusername VARCHAR(50) NOT NULL,
  adminpassword VARCHAR(255) NOT NULL
);

-- Table structure for table `cashistory`
CREATE TABLE IF NOT EXISTS cashistory (
  catastrophicHistory_id SERIAL PRIMARY KEY,
  disasterEvent VARCHAR(250) NOT NULL,
  catastrophicHistory TEXT,
  category VARCHAR(100),
  provinceName VARCHAR(100) NOT NULL,
  province_id INTEGER REFERENCES province(province_id)
);

-- Table structure for table `hotline`
CREATE TABLE IF NOT EXISTS hotline (
  hotline_id SERIAL PRIMARY KEY,
  agency VARCHAR(100) NOT NULL,
  hotlineNumber VARCHAR(100),
  provinceName VARCHAR(100) NOT NULL,
  province_id INTEGER REFERENCES province(province_id)
);

-- Table structure for table `province`
CREATE TABLE IF NOT EXISTS province (
  province_id SERIAL PRIMARY KEY,
  provinceName VARCHAR(100) NOT NULL
);

-- Adding indexes
CREATE INDEX cashistory_province_idx ON cashistory (province_id);
CREATE INDEX hotline_province_idx ON hotline (province_id);

-- Table structure for table `admin_accounts`
ALTER TABLE admin_accounts ALTER COLUMN admin_id SET DEFAULT nextval('admin_accounts_admin_id_seq'::regclass);

-- Table structure for table `cashistory`
ALTER TABLE cashistory ALTER COLUMN catastrophicHistory_id SET DEFAULT nextval('cashistory_catastrophicHistory_id_seq'::regclass);

-- Table structure for table `hotline`
ALTER TABLE hotline ALTER COLUMN hotline_id SET DEFAULT nextval('hotline_hotline_id_seq'::regclass);

-- Table structure for table `province`
ALTER TABLE province ALTER COLUMN province_id SET DEFAULT nextval('province_province_id_seq'::regclass);

-- Foreign key constraints
ALTER TABLE cashistory ADD CONSTRAINT cashistory_province_fk FOREIGN KEY (province_id) REFERENCES province (province_id);
ALTER TABLE hotline ADD CONSTRAINT hotline_province_fk FOREIGN KEY (province_id) REFERENCES province (province_id);
