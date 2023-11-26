CREATE TABLE users (
    id    INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    user_id      NVARCHAR(100) NOT NULL,
    password    NVARCHAR(100) NOT NULL,
    user_name    NVARCHAR(100) NOT NULL,
    email       NVARCHAR(256) NOT NULL,
    created_at  datetime NOT NULL DEFAULT GETDATE(),
    updated_at  datetime,
);
