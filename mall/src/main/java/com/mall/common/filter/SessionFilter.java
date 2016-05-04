package com.mall.common.filter;

import java.io.IOException;

import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;

/**
 * 判断用户是否已处于登录状态，非登录状态，则跳转到首页
 * ClassName: SessionFilter
 * @Description: TODO
 * @author zzd
 * @date 2016-4-15
 */
public class SessionFilter implements Filter {

	public void destroy() {
		
	}

	public void doFilter(ServletRequest arg0, ServletResponse arg1,
			FilterChain arg2) throws IOException, ServletException {
		
	}

	public void init(FilterConfig arg0) throws ServletException {
		
	}

}
