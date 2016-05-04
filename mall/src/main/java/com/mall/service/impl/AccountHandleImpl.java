package com.mall.service.impl;

import java.util.Map;

import org.springframework.stereotype.Component;
import org.springframework.transaction.annotation.Propagation;
import org.springframework.transaction.annotation.Transactional;

import com.mall.service.IAccountHandle;

@Component("accountHandleImpl")
public class AccountHandleImpl implements IAccountHandle {

	@Transactional(propagation=Propagation.REQUIRED,timeout = 2000)
	public int add(Map inMap) {
		
		return 0;
	}

}
