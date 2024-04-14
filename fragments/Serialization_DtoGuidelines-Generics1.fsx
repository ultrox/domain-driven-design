type ResultDto<'OkData,'ErrorData when 'OkData : null and 'ErrorData: null> = {
  IsError : bool  // replaces "Tag" field
  OkData : 'OkData 
  ErrorData : 'ErrorData
  }
