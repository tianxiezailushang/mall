package com.mall.common.filter;

import java.io.IOException;

import javax.servlet.Filter;
import javax.servlet.FilterChain;
import javax.servlet.FilterConfig;
import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;
import javax.servlet.http.HttpServletRequest;

import org.apache.log4j.Logger;

/**
 * 
 * @author zzd
 * @date 2016-4-15 下午01:51:55
 * @AccessTypeFilter.java
 * @comment
 */
public class EncodingFilter  implements Filter {
    final static Logger logger = Logger.getLogger(EncodingFilter.class);
	public void destroy() {
	}

	
	public void doFilter(ServletRequest req, ServletResponse response,
			FilterChain filterChain) throws IOException, ServletException {
		HttpServletRequest request = (HttpServletRequest)req;
		StringBuffer sb = new StringBuffer();
		sb.append("请求的IP为：" + request.getRemoteAddr()).append(request.getRemoteHost()).append(request.getRemotePort());
		logger.info(sb.toString());
		sb.setLength(0);//当前方法比delete 跟 new StringBuffer()方式来清空缓存，效率更高。
		logger.info(new String().format("URL:{},ParameterMap:{}", request.getRequestURL().toString(),request.getParameterMap()));
		filterChain.doFilter(request, response);
	}

	public void init(FilterConfig arg0) throws ServletException {
		
	}

}
