package com.mall.common;

import org.apache.log4j.LogManager;
import org.apache.log4j.Logger;

public class Log4jHelper {
    
	
	
	public Logger getLogger(Class className){
		return LogManager.getLogger(className);
	}
	
	
}
