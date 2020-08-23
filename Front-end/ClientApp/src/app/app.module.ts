import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {MatMenuModule} from '@angular/material/menu';
import {MatButtonModule} from '@angular/material/button';
import {MatCardModule} from '@angular/material/card';
import {MatGridListModule} from '@angular/material/grid-list'
import {HttpClientModule} from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {RouterModule, Routes} from '@angular/router';
import { FlexLayoutModule } from "@angular/flex-layout";
import { MatToolbarModule } from "@angular/material/toolbar";
import {MatFormFieldModule} from '@angular/material/form-field'
import {MatInputModule} from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import {ReactiveFormsModule} from '@angular/forms';
import {MatProgressBarModule} from '@angular/material/progress-bar';
import {MatIconModule} from '@angular/material/icon';
import {MatSidenavModule} from '@angular/material/sidenav';

import { AppComponent } from './app.component';
import { ProductDetailComponent } from './product/product-detail/product-detail.component';
import { ProductListComponent } from './product/product-list/product-list.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ProductCardComponent } from './product/product-card/product-card.component';
import {ProductsService} from './services/products.service';
import {AddProductComponent} from './product/add-product/add-product.component';
import { HomeComponent } from './home/home.component';
import { UserLoginComponent } from './user/user-login/user-login.component';
import { UserRegisterComponent } from './user/user-register/user-register.component';
import {UploadService} from './services/Upload.service'
import { UsersService } from './services/users.service';

const appRoutes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'add-product', component: AddProductComponent},
  {path: 'product-detail/:id', component: ProductDetailComponent},
  {path: 'login', component: UserLoginComponent},
  {path: 'register', component: UserRegisterComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    ProductDetailComponent,
    ProductListComponent,
    NavbarComponent,
    ProductCardComponent,
    AddProductComponent,
    HomeComponent,
    UserLoginComponent,
    UserRegisterComponent,

  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatMenuModule,
    MatButtonModule,
    MatCardModule,
    MatGridListModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes),
    FlexLayoutModule,
    MatToolbarModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    ReactiveFormsModule,
    MatProgressBarModule,
    MatIconModule,
    MatSidenavModule
  ],
  providers: [ProductsService, UploadService, UsersService],
  bootstrap: [AppComponent]
})
export class AppModule { }
