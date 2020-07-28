﻿//=============================================================================================================================
//
// EasyAR 3.0.1-final-r238a6316e
// Copyright (c) 2015-2019 VisionStar Information Technology (Shanghai) Co., Ltd. All Rights Reserved.
// EasyAR is the registered trademark or trademark of VisionStar Information Technology (Shanghai) Co., Ltd in China
// and other countries for the augmented reality technology developed by VisionStar Information Technology (Shanghai) Co., Ltd.
//
//=============================================================================================================================

#import "easyar/types.oc.h"

@interface easyar_JniUtility : NSObject

+ (instancetype)new NS_UNAVAILABLE;
- (instancetype)init NS_UNAVAILABLE;

+ (easyar_Buffer *)wrapByteArray:(void *)bytes readOnly:(bool)readOnly deleter:(void (^)())deleter;
+ (easyar_Buffer *)wrapBuffer:(void *)directBuffer deleter:(void (^)())deleter;

@end
