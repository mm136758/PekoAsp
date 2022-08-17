CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;

CREATE TABLE "Article" (
    "ID" INTEGER NOT NULL CONSTRAINT "PK_Article" PRIMARY KEY AUTOINCREMENT,
    "Title" TEXT NOT NULL,
    "ReleaseDate" TEXT NOT NULL,
    "Link" TEXT NOT NULL,
    "Count" TEXT NOT NULL
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20220812072708_InitialCreate', '6.0.8');

COMMIT;

BEGIN TRANSACTION;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20220814132023_UpdateArticleCountType', '6.0.8');

COMMIT;

BEGIN TRANSACTION;

ALTER TABLE "Article" ADD "Category" TEXT NOT NULL DEFAULT '';

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20220815135253_ArticleAddCategory', '6.0.8');

COMMIT;

BEGIN TRANSACTION;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20220815140850_New_DataAnnotations', '6.0.8');

COMMIT;

