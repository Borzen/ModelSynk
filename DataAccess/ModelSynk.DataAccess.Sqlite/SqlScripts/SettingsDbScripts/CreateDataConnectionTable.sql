CREATE TABLE if not exists DataSourceConnection (
    DataSourceConnectionId INTEGER PRIMARY KEY AUTOINCREMENT
                                   NOT NULL,
    Name                   TEXT    NOT NULL,
    ConnectionString       TEXT    NOT NULL,
    DataSourceType         INTEGER NOT NULL,
    CreatedDateTime        TEXT    NOT NULL,
    UpdatedDateTime        TEXT    NOT NULL
);
