import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule} from '@angular/forms';
import {MatMenuModule} from '@angular/material/menu';
import {MatButtonModule} from '@angular/material/button';
import {MatCardModule} from '@angular/material/card';
import {MatGridListModule} from '@angular/material/grid-list'
import {HttpClientModule} from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {RouterModule, Routes} from '@angular/router';
import {FlexLayoutModule} from "@angular/flex-layout";
import {MatToolbarModule} from "@angular/material/toolbar";
import {MatFormFieldModule} from '@angular/material/form-field'
import {MatInputModule} from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import {ReactiveFormsModule} from '@angular/forms';
import {MatProgressBarModule} from '@angular/material/progress-bar';
import {MatIconModule} from '@angular/material/icon';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatTabsModule} from '@angular/material/tabs';
import {MatListModule} from '@angular/material/list'
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatRadioModule} from '@angular/material/radio';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatTableModule} from '@angular/material/table';
import {MatExpansionModule} from '@angular/material/expansion';
import {MatDialogModule} from '@angular/material/dialog';
import {MatTooltipModule} from '@angular/material/tooltip';
import {MatSortModule} from '@angular/material/sort';
import {MatDividerModule} from '@angular/material/divider';
import {IvyCarouselModule} from 'angular-responsive-carousel';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {MatBadgeModule} from '@angular/material/badge';
import {MatChipsModule} from '@angular/material/chips';
import {MatAutocompleteModule} from '@angular/material/autocomplete';

import { AppComponent } from './app.component';
import { ProductDetailComponent } from './product/product-detail/product-detail.component';
import { ProductCardListingComponent } from './product/product-card-listing/product-card-listing.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ProductCardComponent } from './product/product-card/product-card.component';
import {ProductsService} from './services/products.service';
import { HomeComponent } from './home/home.component';
import { UserLoginComponent } from './user/user-login/user-login.component';
import { UserRegisterComponent } from './user/user-register/user-register.component';
import { UsersService } from './services/users.service';
import {AlertifyService} from './services/alertify.service';
import {AuthService} from './services/auth.service';
import { CatalogComponent } from './catalog/catalog.component';
import {AddProductComponent} from './dashboard/dashboard-products/add-product/add-product.component';
import {CatalogSidenavComponent} from './catalog/catalog-sidenav/catalog-sidenav.component';
import {CatalogFilterMenuComponent} from './catalog/catalog-filter-menu/catalog-filter-menu.component';
import {DeleteDialogContentComponent} from './dashboard/dashboard-products/products-table/delete-dialog-content/delete-dialog-content.component';
import {ProductDetailsResolverService} from './services/product-details-resolver.service';
import {CollectionCardComponent} from './collection/collection-card/collection-card.component';
import {CollectionCardListingComponent} from './collection/collection-card-listing/collection-card-listing.component';
import {FilterPipe} from './pipes/filter.pipe';
import {SortPipe} from './pipes/sort.pipe';
import {ProductListingResolverService} from './services/product-listing-resolver.service';
import {DashboardProductsComponent} from './dashboard/dashboard-products/dashboard-products.component';
import {ProductsTableComponent} from './dashboard/dashboard-products/products-table/products-table.component';
import {DashboardCollectionsComponent} from './dashboard/dashboard-collections/dashboard-collections.component';
import {AddCollectionComponent} from './dashboard/dashboard-collections/add-collection/add-collection.component'
import {CollectionsService} from './services/collections.service';
import {CollectionsTableComponent} from './dashboard/dashboard-collections/collections-table/collections-table.component';
import {CollectionsListingResolverService} from './services/collections-listing-resolver.service';
import {BrandsListingResolverService} from './services/brands-listing-resolver.service';
import {CollectionDeleteDialogComponent} from './dashboard/dashboard-collections/collections-table/collection-delete-dialog/collection-delete-dialog.component';



const appRoutes: Routes = [
  {path: '',
      component: HomeComponent,
      resolve: {cltn_listing : CollectionsListingResolverService}},
  {path: 'login', component: UserLoginComponent},
  {path: 'register', component: UserRegisterComponent},
  {path: 'catalog',
      component: CatalogComponent,
      resolve: {prd_listing : ProductListingResolverService,
            brnd_listing : BrandsListingResolverService,
            cltn_listing : CollectionsListingResolverService}},
  {path:'catalog/:id',
      component: ProductDetailComponent,
      resolve: {prd_details: ProductDetailsResolverService}},
  {path: 'dashboard-collections',
     component: DashboardCollectionsComponent,
     resolve: {cltn_listing : CollectionsListingResolverService}},
    {path: 'dashboard-products',
     component: DashboardProductsComponent,
     resolve: {prd_listing : ProductListingResolverService,
              brnd_listing : BrandsListingResolverService,
              cltn_listing : CollectionsListingResolverService
    }},

]

@NgModule({
  declarations: [
    AppComponent,
    ProductDetailComponent,
    ProductCardListingComponent,
    NavbarComponent,
    ProductCardComponent,
    AddProductComponent,
    HomeComponent,
    UserLoginComponent,
    UserRegisterComponent,
      CatalogComponent,
      ProductsTableComponent,
      CatalogSidenavComponent,
      CatalogFilterMenuComponent,
      DeleteDialogContentComponent,
      CollectionCardComponent,
      CollectionCardListingComponent,
      FilterPipe,
      SortPipe,
      DashboardProductsComponent,
      DashboardCollectionsComponent,
      AddCollectionComponent,
      CollectionsTableComponent,
      CollectionDeleteDialogComponent
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
    MatSidenavModule,
    MatTabsModule,
    MatListModule,
    MatCheckboxModule,
    MatRadioModule,
    MatPaginatorModule,
    MatTableModule,
    MatExpansionModule,
    MatDialogModule,
    MatTooltipModule,
    MatSortModule,
    MatDividerModule,
    IvyCarouselModule,
    FormsModule,
    MatProgressSpinnerModule,
    MatBadgeModule,
    MatChipsModule,
    MatAutocompleteModule

  ],
  providers: [ProductsService,
    UsersService,
     AlertifyService,
      AuthService,
      ProductDetailsResolverService,
      ProductListingResolverService,
      CollectionsService,
      CollectionsListingResolverService,
      BrandsListingResolverService
      ],
  bootstrap: [AppComponent]
})
export class AppModule {



 }
