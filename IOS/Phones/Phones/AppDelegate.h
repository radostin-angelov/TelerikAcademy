//
//  AppDelegate.h
//  Phones
//
//  Created by John Doe on 1/26/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "LocalData.h"

@interface AppDelegate : UIResponder <UIApplicationDelegate>

@property (strong, nonatomic) UIWindow *window;
@property (strong, nonatomic) LocalData *data;

@end

