CREATE TABLE [dbo].[menutable] (
    [item_code]   INT          NOT NULL,
    [item_name]   VARCHAR (50) NULL,
    [category]    NCHAR (10)   NULL,
    [description] VARCHAR (50) NULL,
    [price]       INT          NULL,
    [tax]         INT          NULL,
    [type]        NCHAR (10)   NULL,
    PRIMARY KEY CLUSTERED ([item_code] ASC)
);

