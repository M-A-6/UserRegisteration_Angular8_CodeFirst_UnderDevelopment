import { BrowserModule } from '@angular/platform-browser';
import { NgModule,CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

// import { AppRoutingModule } from './routing/app-routing.module';
import { HomeComponent } from './home/home.component';
import { EmployeeComponent } from './employee/employee.component';
// import { DataTablesModule } from 'angular-datatables';

import {HttpModule } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';
import { EmployeeService } from './services/employee.service';
import { LoginComponent } from './login/login.component';
 import {MDBBootstrapModule } from 'angular-bootstrap-md';

import { Routes ,RouterModule} from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { MenusComponent } from './menus/menus.component';
import { LoginService } from './services/login.service';



const appRoutes: Routes = [
  // { path: 'crisis-center', component: CrisisListComponent },
  // { path: 'hero/:id',      component: HeroDetailComponent },
  // {
  //   path: 'heroes',
  //   component: HeroListComponent,
  //   data: { title: 'Heroes List' }
  // },

  { path: 'login', component: LoginComponent },
  { path: 'home', component: HomeComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'employees', component: EmployeeComponent },
  { path: 'editemployee', component: EmployeeComponent },
 

 // { path: '**', component: PageNotFoundComponent }

  
];


@NgModule({
  declarations: [ HomeComponent, EmployeeComponent ,LoginComponent, RegisterComponent, DashboardComponent, MenusComponent ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(
      appRoutes
      //,{ enableTracing: true } // <-- debugging purposes only
    ),
    
    HttpModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MDBBootstrapModule
    ],
    schemas: [
      CUSTOM_ELEMENTS_SCHEMA
  ],
  providers: [EmployeeService,LoginService],
  bootstrap: [HomeComponent]
})

export class AppModule { }
