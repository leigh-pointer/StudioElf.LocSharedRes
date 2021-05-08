/*  
Create StudioElfLocSharedRes table
*/

CREATE TABLE [dbo].[StudioElfLocSharedRes](
	[LocSharedResId] [int] IDENTITY(1,1) NOT NULL,
	[ModuleId] [int] NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
	[CreatedBy] [nvarchar](256) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](256) NOT NULL,
	[ModifiedOn] [datetime] NOT NULL,
  CONSTRAINT [PK_StudioElfLocSharedRes] PRIMARY KEY CLUSTERED 
  (
	[LocSharedResId] ASC
  )
)
GO

/*  
Create foreign key relationships
*/
ALTER TABLE [dbo].[StudioElfLocSharedRes] WITH CHECK ADD CONSTRAINT [FK_StudioElfLocSharedRes_Module] FOREIGN KEY([ModuleId])
REFERENCES [dbo].Module ([ModuleId])
ON DELETE CASCADE
GO