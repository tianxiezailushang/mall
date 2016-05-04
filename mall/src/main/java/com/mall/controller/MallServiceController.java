package com.mall.controller;


import org.apache.log4j.LogManager;
import org.apache.log4j.Logger;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import com.mall.common.annotation.Customer;

/**
 * 
 * @author zzd
 * @date 2016-4-15 上午11:38:25
 * @MallServiceController.java
 * @comment mall工程接口统一入口
 */
@Controller
@RequestMapping("/mall")
@Customer(type ="mall")
public class MallServiceController {
	 final static Logger logger = LogManager.getLogger(MallServiceController.class);

	@RequestMapping(value = "/hello" , method = RequestMethod.GET)
	public String methodController(){
		logger.debug("*****access in MallServiceController" );
		return null;
	}
	
	@RequestMapping(value = "/hello" , method = RequestMethod.POST)
	public String methodController2(){
		logger.debug("*****access in MallServiceController" );
		return null;
	}
	
}
