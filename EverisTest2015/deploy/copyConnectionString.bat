@echo off
@set base_dir=%1
@set origin_path="%base_dir:~1,-1%ConnectionStrings.example.config"
@set target_path="%base_dir:~1,-1%connectionStrings.config"

IF NOT EXIST %target_path% (
  copy %origin_path% %target_path%  
) ELSE (
  ECHO ConnectionString already exists.
)

exit 0
