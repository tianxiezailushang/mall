package com.mall.common.interceptor;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.springframework.web.servlet.handler.HandlerInterceptorAdapter;

import com.mall.common.annotation.Customer;

public class CustomerAuthInterceptor extends HandlerInterceptorAdapter {

	/**
	 * request可以获取请求中的各种参数
	 * handler可以获取具体处理类的各种信息
	 * 通过获取用户的相关信息A，组别等，与所访问的类的组别信息B进行判断，如果A 包含了B，则允许访问，否则，请求非法，跳转到首页
	 */
	@Override
	public boolean preHandle(HttpServletRequest request, HttpServletResponse response, Object handler)
		throws Exception {
		   Customer   customerExist =  handler.getClass().getAnnotation(Customer.class);
		   if(customerExist == null){
			   return false;
		   }
		return true;
	}
}
